using EFCORE01.Configration;
using EFCORE01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE01.Context
{
    internal class Enterprise : DbContext
    {
        public Enterprise() : base()
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent Api
            //modelBuilder.Entity<Employee>().HasKey(E => E.Id); // this will set the Id to PK

            //modelBuilder.Entity<Employee>().Property(E => E.Id).UseIdentityColumn(1, 1);


            //modelBuilder.Entity<Employee>().Property(E => E.Name).HasColumnType("nvarchar");

            //modelBuilder.Entity<Employee>().Property(E => E.Age).HasDefaultValue(20); 
            #endregion

            #region Using Class Configration
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        //Override this method to set defaults and configure conventions before they run.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = Enterprise; Trusted_Connection = true");
        }

        public DbSet<Employee> Employees { get; set; } //This will tell ef core that i need to Mapp this class into a table in my database
    }
}
