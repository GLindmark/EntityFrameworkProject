using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkProject.Models {
    public class Student {

        public int Id { get; set; }
        [Required]//makes Firstname not null
        [StringLength(30)]//limits the characters to 30
        public string Firstname { get; set; }
        [Required]
        [StringLength(30)]
        public string Lastname { get; set; }
        [Range(600, 2400, ErrorMessage = "SAT score 600 <=x,=2400")]
        public int SAT { get; set; }
        public double GPA { get; set; }
        public bool IsFulltime { get; set; } = true;

        public override string ToString() {
            return $"{this.Id}, {this.Firstname} {this.Lastname}, {this.SAT}, {this.GPA}, {this.IsFulltime}, {this.MajorId}, {this.Major}";
        }

        public int? CourseId { get; set; }
        public virtual Course Course { get; set; }

        public int? MajorId { get; set; }//the '?' creates a nullable int type
        public virtual Major Major { get; set; } 
        //the virtual tells EF that this information is not in Student.  The second "Major" is like Fred.


        //must have a public default constructor
        public Student() {

        }

    }
}
