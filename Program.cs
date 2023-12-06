using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program for swapping + and - operators

            Number num1 = new Number(3);
            Number num2 = new Number(10);

            Number result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");

            result = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {result}");

            Console.ReadKey();
        }
    }
}