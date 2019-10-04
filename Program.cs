using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondFibo
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong count, firstNumber = 1, secondNumber = 1, nestNumber;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            for (count = 2; count < 698; count++)
            {
                nestNumber = firstNumber + secondNumber;
                Console.WriteLine(nestNumber);

                firstNumber = secondNumber;
                secondNumber = nestNumber;
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
