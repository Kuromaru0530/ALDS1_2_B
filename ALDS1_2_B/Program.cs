using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var In = Console.ReadLine().Split(' ');
        var a = Array.ConvertAll(In, x => int.Parse(x));
        var Count = 0;

        for(int i = 0; i < n; i++)
        {
            int minj = i;
            for(int j = i; j < n; j++)
            {
                if (a[j] < a[minj])
                {
                     minj = j;
                    
                }
            }
            if(i != minj)
            {
                int x = 0;

                x = a[i];
                a[i] = a[minj];
                a[minj] = x;
                Count++;
            }
            

            
        }
        Console.WriteLine(string.Join(" ", a));
        Console.WriteLine(Count);
    }  
}