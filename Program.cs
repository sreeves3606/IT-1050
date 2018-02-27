using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_StephanieReves
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA; // first number declared
            int numberB; // second number declared
            int sum; // sum of first and second number declared

            Console.Write("Enter first number: "); // user promted for first number
            numberA = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: "); // user prompted for second number
            numberB = int.Parse(Console.ReadLine());

            sum = numberA + numberB; // first and second numbers added
            Console.WriteLine($"Sum is {sum}");  // resulting sum displayed

            int x; // first variable declared
            int y; // second variable declared
            int z; // third variable declared
            int result; // result of variables

            Console.Write("Enter number for x: "); // user prompted for x
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter number for y: "); // user prompted for y
            y = int.Parse(Console.ReadLine());

            Console.Write("Enter number for z: "); // user prompted z
            z = int.Parse(Console.ReadLine());

            result = (x + y) * (z + 10);
            Console.WriteLine($"Product is {result}");  // resulting sum displayed

            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("Hello\\World");
               
        }
    }
}
