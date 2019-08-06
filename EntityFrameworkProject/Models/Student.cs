using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkProject.Models {
    public class Student {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int SAT { get; set; }
        public double GPA { get; set; }
        public bool IsFulltime { get; set; }
        //must have a public default constructor
        public Student() {

        }

    }
}
