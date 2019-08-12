using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFrameworkProject;//Models;


namespace TestEducationProject {


    [TestClass]
    public class UnitTest1 {


      //      AppDbContext context = null;


        [TestInitialize]
        public void TestInit() {

     //      ; context = new AppDbContext();
        }

        [TestMethod]
        public void TestStudentGetByLastname() {
            var student = Program.GetStudentByLastname("Doe");
            Assert.IsNotNull(student);
            Assert.AreEqual("doe", student.Lastname);
            //    student = Program.GetStudentByLastname("Dooe");
            //    Assert.IsNull(student, "Student is Null");
        }



        [TestMethod]
        public void TestStudentGetByPK() {
            var janedoe = Program.GetStudentById(1);
            //var janedoe = context.Students.Find(1);
            Assert.IsNotNull(janedoe);
            Assert.AreEqual("doe", janedoe.Lastname);
            //var nobody = Program.GetStudentById(999);
           // Assert.IsNull(nobody);





        }
    }
}
