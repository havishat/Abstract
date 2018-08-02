using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract2
{
    public class EmployeeManager
    {
        public int GetTotalSalary(Employee[] employees)
        {
            var sum = 0;
            foreach(var employee in employees)
            {
                sum += employee.GetSalary();
            
            }
            return sum;

        }
    }
}
