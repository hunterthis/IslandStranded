using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandStranded
{
    // https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=visual-studio
    internal class UserContext : DbContext // instal EF Core SQLServel package
    {
        public UserContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Copy this for future projects. Rename the Database=""
            options.UseSqlServer("Server=(localdc)\\mssqllocaldb;Database=IslandGameUserDb;Trusted_Connection=True;");
        }
    }
}
