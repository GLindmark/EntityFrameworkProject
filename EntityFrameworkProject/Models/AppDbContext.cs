using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkProject.Models {
    //should have the word 'Context' in the class to remind you of what it is

    public class AppDbContext : DbContext {

        public AppDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr = "server=localhost\\sqlexpress;database=AppEfdB;trusted_connection=true";
            builder.UseSqlServer(connStr);
        }

        public DbSet<Student> Students { get; set; }//this is a property called Students

        public DbSet<Major> Majors { get; set; }
    }
}
