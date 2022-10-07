using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            empUC9 dMart = new empUC9("DMart", 20, 20, 100);
            empUC9 Reliance = new empUC9("Reliance", 25, 25, 150);
            dMart.compuateEmpWage();
            Console.WriteLine(dMart.toString());
            Reliance.compuateEmpWage();
            Console.WriteLine(Reliance.toString());
            Console.ReadKey();

            /*Console.WriteLine("Enter Number\n  1.Employe Present absent\t  2.Employee daily wage\t  3.Part time wage\t  4.Switch Case\t  5.Wage & Working days\t 6.Max Hours\t 7.lass Method\t 8.multi Company");
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
                case 4:
                    empUC4.UC4();
                    break;
                case 5:
                    empUC5.UC5();
                    break;
                case 6:
                    empUC6.UC6();
                    break;
                case 7:
                    empUC7.UC7();
                    break;
                case 8:
                    empUC8.UC8("Infy", 20, 17, 80);
                    empUC8.UC8("Eberle", 5, 20, 100);
                    break;
                default:
                    Console.WriteLine("Invalide");
                    break;
            }*/
            Console.ReadKey();
        }
    }
}