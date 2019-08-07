using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkProject.Models {
    public class Major {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Description { get; set; }

        public int MinSat { get; set; }

        public Major() {

        }
        public override string ToString() {
            return $"{this.Id} | {this.Description} | {this.MinSat}";
        }
        }
}
