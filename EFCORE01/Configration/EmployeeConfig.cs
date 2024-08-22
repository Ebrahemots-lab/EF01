using EFCORE01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE01.Configration
{
    internal class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.Id); // this will set the Id to PK

            builder.Property(E => E.Id).UseIdentityColumn(1, 1);

            builder.Property(E => E.Name).HasColumnType("nvarchar");

            builder.Property(E => E.Age).HasDefaultValue(20);
        }
    }
}
