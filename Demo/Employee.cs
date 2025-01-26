using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee :IEquatable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  Salary { get; set; }

        //public override bool Equals(object? obj)
        //{
        //    // Employee? other =(Employee?) obj; //  un save custing i dont what can get from function
        //    Employee? other =obj as Employee;//=>success if obj Employee else it be null
        //    if (other == null) return false;
        //    return this.Id == other?.Id && this.Name==other.Name && this.Salary == other.Salary;
        //}

        public bool Equals(Employee? other) //un save custing
        {
            return this.Id == other?.Id && this.Name == other.Name && this.Salary == other.Salary;
        }
    }
}
