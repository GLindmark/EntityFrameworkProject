using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkProject.Models {
    public class Major2 {

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        [Range(600, 2400)]
        public int MinSat { get; set; }


        public Major2() {

        //}
        //public override string ToString() {//this method is such that when ToString is used elsewhere i
        //    return ($"{major.Id} | {major.Description} | {major.MinSat}")base.ToString();
        }
    }
}
