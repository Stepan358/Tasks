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
            for (int i = 1; i <= N; i+= 2)
            {
                numbers.Add(i);
            }
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
        }
    }
}
