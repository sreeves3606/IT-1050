using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Ques4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumber = new int[1000];
            Random random = new Random();

        for (int i = 0; i < randomNumber.Length; i++)// random number generator
            {
                randomNumber[i] = random.Next(0, 100); // required line of code
            }
        foreach (int i in randomNumber) // foreach loop
        {
                Console.WriteLine(i.ToString());
        }
          
        }
    }
}
