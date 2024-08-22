using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE01.Models
{
    //Mapping By Convention

    /*in this case the Ef core will use it's default behavior to map this class
     * By Conventio
     * By Fluent Api
     */
    internal class Employee
    {
        public int Id { get; set; } //Will take this iD AS Pk and put Identity Constrains on it

        public string LastName { get; set; }
        public string? Name { get; set; } //In Dotnet 5 => Nullable 
                                         //In Dotnet 6 => Required and varchar(max)
                                         //if you need to make this field accept null you can use null operator ? 
        public decimal Salary { get; set; } //=> Decimal (18,2) default and Required

        public int? Age { get; set; } // => Will be Nullable<int> Not required
    }
}
