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
            int ch = 0;
            int ch1 = 0;
            bool ch1b = false;
            for (int i = 0; i < N; i++)
            {
                numbers.Add(i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if(numbers[i] % 2 == 0 && ch == 0 )
                {
                    ch1 = numbers[i];
                    ch1b = true;
                }
                if(numbers[i] % 2 == 0 && ch1b == true)
                {
                    ch = numbers[i] * ch1;
                    numbers[i] = ch;
                }
                

            }
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
        }
    }
}
