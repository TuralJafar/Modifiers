using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public bool IsSuccesfull { get; set; }

        public Employee(string name,decimal salary) { 
            Name = name;
            Salary = salary;
        }

        
    }
    
}
