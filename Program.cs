using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Assignment 1.1.2"; 
            Console.WriteLine($"The minimum value of an int variable is {int.MinValue} and the maximum value of an in is {int.MaxValue} ");
            Console.WriteLine();

            Console.WriteLine($"The minimum value fo a float value is {float.MinValue} and the maximum value is {float.MaxValue}");
            Console.WriteLine();

            Console.WriteLine($"The minimum value of a decimal value is {decimal.MinValue} and the maximum value is {decimal.MaxValue}");
            Console.WriteLine();

            Console.WriteLine($"The minimum value of a double value is {double.MinValue} and the maximum value is {double.MaxValue}");

            Console.Read(); 

        }
    }
}
