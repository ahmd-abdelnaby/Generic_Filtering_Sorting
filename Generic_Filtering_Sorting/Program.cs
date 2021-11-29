using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Filtering_Sorting
{
    public static class Program
    {
        static void Main(string[] args)
        {

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
            foreach (var item in sr)
            {
                Console.WriteLine(item);
            }

            var orderStudentsById = OrderedList<Student>.ToOrderedList(students.AsQueryable(), "Name", OrderType.Descending);
            foreach (var student in orderStudentsById)
            {
                //Console.WriteLine(student.Id +" " + student.Name);
            }

            var filter = new Dictionary<string, Filter>();
            filter.Add("DOB", new Filter { Method = FilterMethods.DateIsNot , Value = "1998/12/12" });
            filter.Add("Name", new Filter { Method = FilterMethods.Contains, Value = "Bill" });
            filter.Add("Id", new Filter { Method = FilterMethods.Equal, Value = "7" });
            var filteredStudentsByName = FilteredList<Student>.ToFilteredList(students.AsQueryable(), filter);
            foreach (var student in filteredStudentsByName)
            {
                Console.WriteLine(student.Id + " " + student.Name);
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
