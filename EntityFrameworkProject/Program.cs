using EntityFrameworkProject.Models;//allows the use of the AppDbContext
using System;
using System.Linq;//allows the use of ToList, OrderBy, ToArray, etc.

namespace EntityFrameworkProject {
    class Program {
        static void Main(string[] args) {

            var context = new AppDbContext();//we can only access the tables we include in the DbContext

            //var major = new Major();
            //major.Id = 0;
            //major.Description = "Nursing";
            //major.MinSat = 1100;

            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Accounting";
            //major.MinSat = 1300;

            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Public Speaking";
            //major.MinSat = 5;

            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Golf Science";
            //major.MinSat = 1400;

            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "ESports";
            //major.MinSat = 800;

            //context.Majors.Add(major);


            //major = new Major();
            //major.Id = 0;
            //major.Description = "Sociology";
            //major.MinSat = 800;

            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "History";
            //major.MinSat = 900;

            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Political Science";
            //major.MinSat = 1000;

            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Theater";
            //major.MinSat = 200;

            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Computer Science";
            //major.MinSat = 1500;

            //context.Majors.Add(major);


            //Remove Data from the table
            var major = context.Majors.Find(5);//to remove data
            context.Remove(major);

            context.SaveChanges();//the SaveChanges must be done to update the database.  You can do multiple Add with just one SaveChanges.
            //var major = context.Majors.Find(4);//need to Find first (use the PK)
            //if (major == null) {
            //    throw new Exception("Not Found");//this confirms the record is not null.  If null, it will stop because of the end braces
            //}
            //major.Description = "Math";
            //major.MinSat = 1300;


            //Below is how to add new data to an existing table
            //var major = new Major();
            //major.Id = 0;
            //major.Description = "Biology";
            //major.MinSat = 1100;

            //context.Majors.Add(major);



            //foreach (var major in context.Majors.ToList()) {
            //var major = (student.Major == null) ? "Undeclared" : student.Major.Description;
            //Console.WriteLine($"{student.Firstname} {student.Lastname} {major}");
            //Console.WriteLine(major);
            //Console.WriteLine($"{student}");

            //foreach (var student in context.Students.Where(student => student.Major != null).OrderBy(m => m.Major.Description).ToList()) {
            //var major = (student.Major == null) ? "Undeclared" : student.Major.Description;
            //Console.WriteLine($"{student.Firstname} {student.Lastname} {major}");
            //Console.WriteLine(student);
            //Console.WriteLine($"{student}");
        }


        //var students = context.Students.ToList();//always start with the context then '.' then property i.e."Students" then '.' 
        //                                         // then a method i.e. "ToArray()"
        //  var students = context.Students.OrderBy(s => s.Firstname).ToList();
        //Console.WriteLine($"{students}");

        //foreach (var student in students) {//it always needs to be variable name 'student' then '.' then ' property 'Firstame' or 'Lastname'
        //    Console.WriteLine($"{student.Firstname} {student.Lastname} {student.Major.Id}"
        //        );
        //}



        //var studentAvergeSat = context.Students.Average(s => s.SAT);

        //Console.WriteLine($"The Average SAT:{studentAvergeSat}");

        //var majors = context.Majors.OrderBy(m => m.Description).ToList();

        //    foreach (var major in majors) {

        //        Console.WriteLine($"{major.Id} | {major.Description} | {major.MinSat}");
        //    }

        // var majors = context.Majors.OrderBy(m => m.Description).ToList();

        //foreach (var major in context.Majors.OrderBy(m => m.Description).ToList()) {//put the "context.Majors...." instead of first creating the variable

        //    Console.WriteLine(major);
        //}

        //var genStudies = context.Majors.Find(1);
        //Console.WriteLine(genStudies); // ToString is always available because it is in the Original framework



    




        //}
    }
}
