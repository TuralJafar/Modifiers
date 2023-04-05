using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Manager
    {
        public string? Company { get; set; }
        public void GetPromotion(Employee employee)//protected void
        {
            
            if (employee.Salary > 300) 
            {
                employee.Salary += 100;
               // Console.WriteLine(employee.Salary);
                
            }
            else
            {
                Console.WriteLine("Maashi duzgun daxil edin.");
            }
        }
        
       
    }
}
//GetPromotion a protected verdikde program.cs methodu cagira bilmediyim ucun public yazdim((