using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Ques2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "0-January", "1-February", "2-March", "3-April", "4-May", "5-June", "6-July", "7-August", "8-September", "9-October", "10-November", "11-December" }; // order of months
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int counter = 0; counter < array.Length; ++counter) ;
        }
    }
}
