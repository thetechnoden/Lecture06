using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class MathOperations
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static int[] Add(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                throw new ArgumentException("Arrays must have the same length for addition.");

            int[] result = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }
            return result;
        }
    }
}
