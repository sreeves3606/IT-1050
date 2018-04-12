using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_Final_Final_Final
{
    class MyMath
    {
        static void Main(string[] args)
        {
            //User enters two numbers
            Console.Write("Enter first number: ");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double operand2 = double.Parse(Console.ReadLine());

            //Addition Method
            double result = operand1 + operand2; 
            Console.WriteLine(result);

            //Multiplication Method
            double result1 = operand1 * operand2;
            Console.WriteLine(result1);

            //Subtraction Method
            double result2 = operand1 - operand2;
            Console.WriteLine(result2);

            //Division Method
            double result3 = operand1 / operand2;
            Console.WriteLine(result3);
        }
        
       
    }
}
            