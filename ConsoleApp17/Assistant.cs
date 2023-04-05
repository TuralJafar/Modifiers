using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Assistant:Manager
    {
        public Assistant(string name,decimal salary) 
        {
            
        }
        public void GetFeedback(Employee employee)
        {
            if (employee.IsSuccesfull) 
            {
                GetPromotion(employee);


            }
        }


    }
}
