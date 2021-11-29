using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Filtering_Sorting
{
    static class DoubleExtensions
    {
        public static bool GreaterThan(this double x, double y)
        {
            return x > y;
        }
        public static bool LessThan(this double x, double y)
        {
            return x < y;
        }
        public static bool Equal(this double x, double y)
        {
            return x == y;
        }
        public static bool NotEqual(this double x, double y)
        {
            return x != y;
        }
    }

    static class IntExtensions
    {
        public static bool GreaterThan(this int x, int y)
        {
            return x > y;
        }
        public static bool LessThan(this int x, int y)
        {
            return x < y;
        }
        public static bool Equal(this int x, int y)
        {
            return x == y;
        }
        public static bool NotEqual(this int x, int y)
        {
            return x != y;
        }
    }
    static class StringExtensions
    {
        public static bool GreaterThan(this string x, string y)
        {
            double xx = (x != null) ? double.Parse(x) : 0;
            double yy = (y != null) ? double.Parse(y) : 0;

            return xx > yy;
        }
        public static bool LessThan(this string x, string y)
        {
            double xx = (x != null) ? double.Parse(x) : 0;
            double yy = (y != null) ? double.Parse(y) : 0;

            return xx < yy;
        }
        public static bool Equal(this string x, string y)
        {
            double xx = (x !=null) ? double.Parse(x): 0;
            double yy = (y != null) ? double.Parse(y) : 0;

            return xx == yy;
        }
        public static bool NotEqual(this string x, string y)
        {
            double xx = (x != null) ? double.Parse(x) : 0;
            double yy = (y != null) ? double.Parse(y) : 0;

            return xx != yy;
        }
        public static bool StartsWith(this string x, string y)
        {
            return (x != null) ? x.ToLower().StartsWith(y.ToLower()) : false;
        }
        public static bool Contains(this string x, string y)
        {
            return (x != null) ? x.ToLower().Contains(y.ToLower()) : false;
        }
        public static bool EndsWith(this string x, string y)
        {
            return (x != null) ? x.Trim().ToLower().EndsWith(y.ToLower()) : false;
        }
        public static bool DateIs(this string x, string y)
        {
            if (x == null) return false;
            var xx = DateTime.Parse(x);
            return xx.Date.ToString("yyyy-MM-dd") == y;
        }
        public static bool DateIsNot(this string x, string y)
        {
            if (x == null) return false;
            var xx = DateTime.Parse(x);
            return xx.Date.ToString("yyyy-MM-dd") != y;
        }
        public static bool DateIsBefore(this string x, string y)
        {
            if (x == null) return false;
            var xx = DateTime.Parse(x);
            var yy = DateTime.Parse(y);
            return xx.Date < yy.Date;
        }
        public static bool DateIsAfter(this string x, string y)
        {
            if (x == null) return false;
            var xx = DateTime.Parse(x);
            var yy = DateTime.Parse(y);
            return xx.Date > yy.Date;
        }

        public static string FirstCharToUpper(this string input) =>
       input switch
       {
           null => throw new ArgumentNullException(nameof(input)),
           "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
           _ => input.First().ToString().ToUpper() + input.Substring(1)
       };
    }
    static class DateExtensions
    {
        public static bool DateIs(this DateTime x, DateTime y)
        {
            return x.Date==y.Date;
        }
        public static bool DateIsNot(this DateTime x, DateTime y)
        {
            return x.Date != y.Date;
        }
        public static bool DateIsBefore(this DateTime x, DateTime y)
        {
            return x.Date < y.Date;
        }
        public static bool DateIsAfter(this DateTime x, DateTime y)
        {
            return x.Date > y.Date;
        }
    }
}
