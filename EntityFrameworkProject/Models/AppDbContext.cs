using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkProject.Models {
    //should have the word 'Context' in the class to remind you of what it is
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options)//options should be plural.  The constructor must be the same name as class.
            : base(options) {

        }

        public DbSet<Student> Students { get; set; }
    }
}
