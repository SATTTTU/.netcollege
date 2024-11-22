using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Employee
    {
        public string name { get; set; }
        public int perhour { get; set; }
        public int hourcount { get; set; }
        public void salary()
        {
            Employee employee = new Employee();
            employee.name = "Satish Timalsina";
            employee.perhour = 40;
            employee.hourcount = 4;
            decimal  totalsalary = employee.total();
            Console.WriteLine($"The total salary of {employee.name} is "+totalsalary);
        }
        decimal total()
        {
            var  gettotalsalary = perhour * hourcount;
            return gettotalsalary;
        }
    }
}
