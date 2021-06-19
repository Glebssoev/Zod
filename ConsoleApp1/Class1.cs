using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Fuu(params int[] result)
        {
            int sum = 0;
            for (int i = 0; i < result.Length; i++)
            {
                sum += result[i];
            }

            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            int[] arr = new[] {1, 2, 4, 6, 9};
            Fuu(arr);
            
        }

    }
}
