using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandStranded
{
    // https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=visual-studio
    public class UserContext : DbContext // install EF Core SQLServel package. Must be public to work on Spectre.Console
    {
        public UserContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Copy this for future projects. Rename the Database=""
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=IslandGameUserDb;Trusted_Connection=True;");
        }

        // crucial step
        //this adds Users to the DBcontext
        public DbSet<User> Users { get; set; }
    }
}
