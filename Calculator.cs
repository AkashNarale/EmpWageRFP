using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Calculator
    {
        int num1 = 10;
        int num2 = 24;
        int result;

        void DisplayResult()
        {
            Console.WriteLine(result);
            Console.ReadLine();
        }
        void add()
        {
            result = num1 + num2;
            DisplayResult();
        }
        void subtract()
        {
            result = num2 - num1;
            DisplayResult();
        }
        void multiply()
        {
            result = num1 * num2;
            DisplayResult();
        }
        void divide()
        {
            result = num2 / num1;
            DisplayResult();
        }

        public static void Main2(string[] args)
        {
            Calculator obj = new Calculator();
            obj.add();
        }
        
    }
}
