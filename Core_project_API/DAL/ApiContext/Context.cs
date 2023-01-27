using Core_project_API.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_project_API.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JNJNVEQ\\MERTSQL;database=CoreProjeDB2; integrated security=true");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
