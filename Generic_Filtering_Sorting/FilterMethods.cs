using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Filtering_Sorting
{
    public class FilterMethods
    {
         public static string Contains => "Contains";
         public static string StartsWith => "StartsWith";
         public static string EndsWith => "EndsWith";
         public static string LessThan => "LessThan";
         public static string Equal => "Equal";
         public static string NotEqual => "StartsWith";
         public static string GreaterThan => "GreaterThan";
         public static string DateIs => "DateIs";
         public static string DateIsNot => "DateIsNot";
         public static string DateIsBefore => "DateIsBefore";
         public static string DateIsAfter => "DateIsAfter";
    }
    public class OrderType
    {
        public static string Ascending => "asc";
        public static string Descending => "desc";

    }
}
