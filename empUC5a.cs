using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class empUC5a
    {
        public static void UC6()
        {
            const int partTime = 1;
            const int fullTime = 2;
            int empWage = 0;
            int perHr = 20;
            int empHr = 0;
            int totalEmpWage = 0;
            int noWorkingDays = 2;
            for (int day = 0; day < noWorkingDays; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case partTime:
                        empHr = 4;
                        break;
                    case fullTime:
                        empHr = 8;
                        break;
                    default:
                        break;
                }
                empWage = empHr * perHr;
                totalEmpWage += empWage;
                Console.WriteLine("EmpWage is :" + empWage);
            }
            Console.WriteLine("Total Emp Wage is :" +totalEmpWage);
        }
    }
}

