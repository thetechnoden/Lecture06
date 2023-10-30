using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = MathOperations.Add(5, 3);
            double result2 = MathOperations.Add(2.5, 3.7);
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] resultArray = MathOperations.Add(array1, array2);

            Console.WriteLine("Result 1: " + result1);
            Console.WriteLine("Result 2: " + result2);
            Console.WriteLine("Array Result: " + string.Join(", ", resultArray));
        }
    }
}