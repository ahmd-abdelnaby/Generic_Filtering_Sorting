using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Generic_Filtering_Sorting
{
    public class OrderedList<T> 
    {
        public OrderedList(string field, string type)
        {
            this.field = field;
            this.type = type;
            
        }
        public string field { get; }
        public string type { get; }

        public static IOrderedQueryable<T> ToOrderedList(IQueryable<T> entity,string SortField,string SortType)
        {
            var parameter = Expression.Parameter(typeof(T), "x");
            Expression property = Expression.Property(parameter, SortField);
            var lambda = Expression.Lambda(property, parameter);

            // REFLECTION: source.OrderBy(x => x.Property)
            MethodInfo orderByMethod = SortType == "desc" ? orderByMethod = typeof(Queryable).GetMethods().First(x => x.Name == "OrderByDescending" && x.GetParameters().Length == 2)
                : orderByMethod = typeof(Queryable).GetMethods().First(x => x.Name == "OrderBy" && x.GetParameters().Length == 2);
            var orderByGeneric = orderByMethod.MakeGenericMethod(typeof(T), property.Type);
            var result = orderByGeneric.Invoke(null, new object[] { entity, lambda });
            return (IOrderedQueryable<T>)result;
        }
    }
}
