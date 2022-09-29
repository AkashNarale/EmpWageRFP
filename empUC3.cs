using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class empUC3
    {
        public static void UC3()
        {
            int fullTime = 1;
            int partTime = 2;
            int empRatePerHr = 20;
            int empWage = 0;
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == fullTime)
            {
                empHrs = 8;
            }
            else if (empCheck == partTime)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHr;
            Console.WriteLine("Employee Wage is :" + empWage);
            Console.ReadKey();
        }

    }
}
