using System.Threading.Channels;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Manager manager=new Manager();
            Employee employee = new Employee("Tural",1200);
            Assistant assistant=new Assistant("Agha",900);
            manager.GetPromotion(employee);
           
            Console.WriteLine(employee.Salary);
            
        }   
    }
}
