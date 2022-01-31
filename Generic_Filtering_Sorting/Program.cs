using Generic_Filtering_Sorting.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Filtering_Sorting
{
    public static class Program
    {
        static void Main(string[] args)
        {
            SCMQualityContext sCMQualityContext = new SCMQualityContext();
            
            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Steve" ,DOB = DateTime.Parse("1998/12/12")},
                new Student(){ Id = 11, Name="Abdul",DOB = DateTime.Parse("1998/10/12")},
                new Student(){ Id = 12, Name="Ram",DOB = DateTime.Parse("1998/8/5")},
                new Student(){ Id = 5, Name="Bill",DOB = DateTime.Parse("1998/1/7")},
                new Student(){ Id = 3, Name="Ram" ,DOB = DateTime.Parse("1998/2/4")},
                new Student(){ Id = 4, Name="Abdul" ,DOB = DateTime.Parse("2000/1/10")},
                new Student(){ Id = 9, Name="Bill" ,DOB = DateTime.Parse("2012/1/17")},
                new Student(){ Id = 10, Name="Steve" ,DOB = DateTime.Parse("2021/5/31")},
            };

            var sr = students.Select(s => s.Id = 12);
            
            // Apply Sorting
            var orderMerchantsById = OrderedList<Merchants>.ToOrderedList(sCMQualityContext.Merchants.AsQueryable(), "Id", OrderType.Ascending);
            foreach (var merchant in orderMerchantsById)
            {
                Console.WriteLine(merchant.Id +" " + merchant.Name);
            }

            // Apply Filtering
            // Swap between commneted and uncommneted filters
            var filter = new Dictionary<string, Filter>();

            filter.Add("Created", new Filter { Method = FilterMethods.DateIs , Value = "2021/04/07" });

            //filter.Add("Name", new Filter { Method = FilterMethods.Contains, Value = "حسن" });

            //filter.Add("Id", new Filter { Method = FilterMethods.Equal, Value = "7" });

            var filteredMerchantsyName = FilteredList<Merchants>.ToFilteredList(sCMQualityContext.Merchants.AsQueryable(), filter);
            foreach (var merchant in filteredMerchantsyName)
            {
                //Console.WriteLine(merchant.Id + " " + merchant.Name);
            }
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
    }
}
