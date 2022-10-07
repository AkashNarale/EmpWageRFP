using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class empUC6
    {
        const int partTime = 1;
        const int fullTime = 2;
        const int perHr = 20;
        const int noOfWorkingDays = 20;
        const int maxHrsInMonth = 100;
        public static void UC6()
        {
            int empHr = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays < noOfWorkingDays)
            {
                //totalWorkingDays++;
                totalWorkingDays = totalWorkingDays + 1;
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
                        empHr = 0;
                        break;
                }
                totalEmpHrs += empHr;
                Console.WriteLine("Days# :" + totalWorkingDays + "Emp Hrs :" + empHr);
            }
            int totalEmpWage = totalEmpHrs * perHr;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
            Console.WriteLine("Total Emp Hr :" + totalEmpHrs);
            Console.ReadKey();
        }
    }
}
