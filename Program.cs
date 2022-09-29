using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number\n 1. Employe Present absent\t 2. Employee daily wage\t 3. Part time wage");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    empUC1.UC1();
                    break;
                case 2:

                    empUC2.UC2();
                    break;
                case 3:
                    empUC3.UC3();
                    break;
                default:
                    Console.WriteLine("Invalide");
                    break;
            }
        }
    }
}