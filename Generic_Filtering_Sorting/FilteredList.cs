using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Generic_Filtering_Sorting
{
    class FilteredList<T> 
    {
        public FilteredList(string field, string type)
        {
            this.field = field;
            this.type = type;

        }
        public static Dictionary<Type, int> typeDict = new Dictionary<Type, int>
        {
            {typeof(int),0},
            {typeof(double),1},
            {typeof(string),2},
            {typeof(DateTime),3},
            {typeof(Nullable<DateTime>),4}
        };

        public string field { get; }
        public string type { get; }
        public static IEnumerable<T> ToFilteredList(IEnumerable<T> items, Dictionary<string,Filter> filters)
        {
            foreach (var filter in filters)
            {
                var Key = filter.Key;
                Key=Key.FirstCharToUpper();
                IEnumerable<PropertyInfo> props;
                if (!string.IsNullOrEmpty(Key))
                    props = new PropertyInfo[] { typeof(T).GetProperty(Key) };
                else
                    props = typeof(T).GetProperties();
                props = props.Where(x => x != null);
                Expression lastExpr = null;
                ParameterExpression paramExpr = Expression.Parameter(typeof(T), "x");
                foreach (var prop in props)
                {
                    var propExpr = GetPropertyExpression(prop, paramExpr,filter.Value.Method, filter.Value.Value);
                    if (lastExpr == null)
                        lastExpr = propExpr;
                    else
                        lastExpr = Expression.MakeBinary(ExpressionType.Or, lastExpr, propExpr);
                }
                if (lastExpr == null)
                    continue;
                var filterExpr = Expression.Lambda(lastExpr, paramExpr);
                items = items.Where<T>((Func<T, bool>)filterExpr.Compile()).ToList();
            }

            return items;
        }

        private static Expression GetPropertyExpression(PropertyInfo prop, ParameterExpression paramExpr,string queryFilter ,string value)
        {
            var memberAcc = Expression.MakeMemberAccess(paramExpr, prop);
            ConstantExpression valueExpr = null;
            MethodInfo containsMember = null;
            switch (typeDict[prop.PropertyType])
            {
                case 0:
                    {
                        valueExpr = Expression.Constant(int.Parse(value));
                        containsMember = typeof(IntExtensions).GetMethod(queryFilter);
                        break;
                    }
                case 1:
                    {
                        valueExpr = Expression.Constant(double.Parse(value));
                        containsMember = typeof(DoubleExtensions).GetMethod(queryFilter);
                        break;
                    }
                case 2:
                    {
                        valueExpr = Expression.Constant(value);
                        containsMember = typeof(StringExtensions).GetMethod(queryFilter);
                        break;
                    }
                case 3:
                case 4:
                    {
                        DateTime? dt = string.IsNullOrEmpty(value) ? (DateTime?)null : DateTime.Parse(value);
                        valueExpr = Expression.Constant(dt);
                        containsMember = typeof(DateExtensions).GetMethod(queryFilter);
                        break;
                    }
                default:
                    {
                        goto case 2;
                    }
            }
            Expression exx = Expression.Call(containsMember, memberAcc, valueExpr);
            return exx;
        }
    }
}
