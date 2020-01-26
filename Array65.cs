
using System;
using System.Collections;
using System.Collections.Generic;
namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int N = Convert.ToInt32(Console.ReadLine());
            for ( int i=0; i < N; i++)
            {
                numbers.Add(i);
                numbers[i] = Convert.ToInt32(Console.ReadLine()) + i;
            }
            foreach (int value in numbers)
            {
                Console.WriteLine(value + 1);
            }
        }
    }
}
