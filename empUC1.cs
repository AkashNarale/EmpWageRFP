using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class empUC1
    {
        public static void UC1()
        {
            int present = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == present)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadKey();
        }
    }
}
