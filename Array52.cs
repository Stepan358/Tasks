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
            for (int i = 0; i <= N; i++)
            {
                numbers.Add(i);
                numbers2.Add(i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i] < 5)
                {
                    numbers2[i] = numbers[i] * 2;
                }
                else
                {
                    numbers2[i] = numbers[i] / 2;
                }
            }
        }
    }
}
