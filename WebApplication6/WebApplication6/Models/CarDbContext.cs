using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    
    
        public class CarDbContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseSqlServer(@"Server=LAPTOP-11F3JSJB;Database=Cardb3;Trusted_Connection=true;");
            }
            public DbSet<Car> Cars { get; set; }
            //public DbSet<AutoSalon> AutoSalons { get; set; }
        }
    }

