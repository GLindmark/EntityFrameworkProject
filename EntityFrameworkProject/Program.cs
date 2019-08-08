using EntityFrameworkProject.Models;//allows the use of the AppDbContext
using System;
using System.Linq;//allows the use of ToList, OrderBy, ToArray, etc.

namespace EntityFrameworkProject {
    class Program {
        static void Main(string[] args) {

            var context = new AppDbContext();//we can only access the tables we include in the DbContext

            //var major = context.Majors.SingleOrDefault(m => m.Description == "ESports");
            //var course = new Course {
            //    Name = "Controller 101",
            //    Instructor = "Ms. Take",
            //    Credit = 2,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);

            //major = context.Majors.SingleOrDefault(m => m.Description == "Math");
            //course = new Course {
            //    Name = "Algebra 301",
            //    Instructor = "Dr. Bamber",
            //    Credit = 3,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);


            //major = context.Majors.SingleOrDefault(m => m.Description == "Psychology");
            //course = new Course {
            //    Name = "Mindfulness 201",
            //    Instructor = "Dr. Buddha",
            //    Credit = 3,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);


            //major = context.Majors.SingleOrDefault(m => m.Description == "History");
            //course = new Course {
            //    Name = "Ancient Mesopotamia 303",
            //    Instructor = "Dr. Tarjet",
            //    Credit = 1,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);


            //major = context.Majors.SingleOrDefault(m => m.Description == "Psychology");
            //course = new Course {
            //    Name = "Self Improvement 303",
            //    Instructor = "Dr. Ham",
            //    Credit = 2,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);


            //major = context.Majors.SingleOrDefault(m => m.Description == "Biology");
            //course = new Course {
            //    Name = "Fungi 202",
            //    Instructor = "Dr. E-Kholeye",
            //    Credit = 3,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);


            //major = context.Majors.SingleOrDefault(m => m.Description == "Math");
            //course = new Course {
            //    Name = "Geometry 102",
            //    Instructor = "Dr. Full",
            //    Credit = 2,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);


            //major = context.Majors.SingleOrDefault(m => m.Description == "Nursing");
            //course = new Course {
            //    Name = "Sedation 303",
            //    Instructor = "Dr. Snooze",
            //    Credit = 1,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);


            //major = context.Majors.SingleOrDefault(m => m.Description == "Criminal Justice");
            //course = new Course {
            //    Name = "Nagel MS 101",
            //    Instructor = "Dr. Bridget",
            //    Credit = 3,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);


            //context.SaveChanges();


            //var major = context.Majors.SingleOrDefault(m => m.Description == "ESports");//looks for Computer Science, returns the Id
            //var student = new Student {
            //    Firstname = "J",
            //    Lastname = "Bird",
            //    GPA = 1.7,
            //    SAT = 1100,
            //    IsFulltime = true,
            //    MajorId = major.Id,
            //};

            //context.Students.Add(student);
            // major = context.Majors.SingleOrDefault(m => m.Description == "Public Speaking");//looks for Computer Science, returns the Id

            // student = new Student {
            //    Firstname = "P",
            //    Lastname = "Star",
            //    GPA = 1.7,
            //    SAT = 650,
            //    IsFulltime = false,
            //    MajorId = major.Id,
            //};

            //context.Students.Add(student);
            // major = context.Majors.SingleOrDefault(m => m.Description == "History");//looks for Computer Science, returns the Id

            // student = new Student {
            //    Firstname = "J",
            //    Lastname = "Neutron",
            //    GPA = 5.0,
            //    SAT = 2400,
            //    IsFulltime = true,
            //    MajorId = major.Id,
            //};

            //context.Students.Add(student);
            // major = context.Majors.SingleOrDefault(m => m.Description == "Golf Science");//looks for Computer Science, returns the Id

            //student = new Student {
            //    Firstname = "T",
            //    Lastname = "Turner",
            //    GPA = 2.5,
            //    SAT = 1300,
            //    IsFulltime = true,
            //    MajorId = major.Id,
            //};

            //context.Students.Add(student);
            //major = context.Majors.SingleOrDefault(m => m.Description == "Sociology");//looks for Computer Science, returns the Id

            //student = new Student {
            //    Firstname = "S",
            //    Lastname = "Rogers",
            //    GPA = 4.6,
            //    SAT = 1000,
            //    IsFulltime = false,
            //    MajorId = major.Id,
            //};

            //context.Students.Add(student);
            //context.SaveChanges();//the SaveChanges must be done to update the database.  You can do multiple Add with just one SaveChanges.
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
            //var major = context.Majors.Find(3);//to remove data
            //context.Remove(major);

            //var major = context.Majors.Find(4);//This is used to update information.  Need to 'Find' first (use the PK)
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
