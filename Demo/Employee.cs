using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  Salary { get; set; }

        public override bool Equals(object? obj)
        {
            Employee? other =(Employee?) obj; //  un save custing i dont what can get from function
            return this.Id == other?.Id && this.Name==other.Name && this.Salary == other.Salary;
        }
    }
}
