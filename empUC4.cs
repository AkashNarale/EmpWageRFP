using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class empUC4
    {
        public static void UC4()
        {
            int empWage = 0;
            const int fullTime = 2;
            const int partTime = 1;
            int empHr = 0;
            int perHr = 20;
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
            empWage = empHr * perHr;
            Console.WriteLine("Employee Wage is :" +empWage);
        }
    }
}
