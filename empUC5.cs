using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class empUC5
    {
        public static void UC5()
        {
            int partTime = 1;
            int fullTime = 2;
            int empWage = 0;
            int perHr = 20;
            int empHr = 0;
            int totalEmpWage = 0;
            int noWorkingDays = 20;
            for(int day = 0; day < noWorkingDays; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                if (empCheck == fullTime)
                {
                    empHr = 8;
                }
                else if (empCheck == partTime)
                {
                    empHr = 4;
                }
                else
                {
                    empHr = 0;
                }
                empWage = empHr * perHr;
                totalEmpWage += empWage;
                Console.WriteLine("EmpWage is :" + empWage);
            }
            Console.WriteLine("Total Emp Wage is :" + totalEmpWage);
        }
    }
}
