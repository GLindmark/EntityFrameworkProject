using EntityFrameworkProject.Models;//allows the use of the AppDbContext
using System;
using System.Linq;//allows the use of ToList, OrderBy, ToArray, etc.

namespace EntityFrameworkProject {
    class Program {
        static void Main(string[] args) {

            var context = new AppDbContext();

            //var students = context.Students.ToList();//always start with the context then '.' then property i.e."Students" then '.' 
            //then a method i.e. "ToArray()"
            // var students = context.Students.OrderBy(s => s.Firstname).ToList();



            var studentAvergeSat = context.Students.Average(s => s.SAT);

            Console.WriteLine($"The Average SAT:{studentAvergeSat}");

            //foreach(var student in students) {//it always needs to be variable name 'student' then '.' then ' property 'Firstame' or 'Lastname'
            //    Console.WriteLine($"{student.Firstname}"
            //        );
            //}


        }
    }
}
