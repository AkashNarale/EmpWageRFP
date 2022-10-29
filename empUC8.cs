using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class empUC8
    {
        const int partTime = 1;
        const int fullTime = 2;
        public static int UC8(string company, int perHr, int noOfWorkingDays, int hrsPerMonth)
        {
            int empHr = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= hrsPerMonth && totalWorkingDays < noOfWorkingDays)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHr;
                Console.WriteLine("Days# :" + totalWorkingDays + "Emp Hrs :" + empHr);
            }
            int totalEmpWage = totalEmpHrs * perHr;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
            Console.WriteLine("Total Emp Hr :" + totalEmpHrs);
            return totalEmpWage;
        }
    }
}
