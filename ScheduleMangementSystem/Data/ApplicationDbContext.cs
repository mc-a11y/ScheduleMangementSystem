using Microsoft.EntityFrameworkCore;
using ScheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ScheduleItem> ScheduleItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ScheduleDb;Trusted_Connection=True;");
        }
    }
}



