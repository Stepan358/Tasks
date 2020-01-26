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
            List<int> numbers2 = new List<int>();
            int N = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            for (int i = 0; i <= N; i ++)
            {
                numbers.Add(i);
                numbers2.Add(i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                numbers2[i] = Convert.ToInt32(Console.ReadLine());
                r = numbers[i] - numbers2[i];
                numbers[i] = numbers2[i];
                numbers2[i] = numbers[i];
            }
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
            foreach (int value2 in numbers2)
            {
                Console.WriteLine(value2 + r);
            }
        }
    }
}