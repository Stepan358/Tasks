using System;
using System.Collections;
using System.Collections.Generic;



    class Program
{

    static void Main(string[] args)
    {
        int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 8, 8, 9, 8 };
        bool k = false;
        int  MaxIndex = 1, max = a[1];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
            if (a[i] > a[0] && a[i] < a[9]) { k = true; }
        }
        if (k)
        {
            for (int i = 0; i < a.Length; i++)
           {
                if (a[i] > a[0] && a[i] < a[9] && a[i] > max) { max = a[i]; MaxIndex = i+1; }
                
            }
            Console.WriteLine(MaxIndex);

        }

        else
            Console.WriteLine("Нет  елементов");

        Console.ReadKey();
    }
}
