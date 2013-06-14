using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimalnoe 4islo bolwe zadannogo");
            int min = Convert.ToInt16(Console.ReadLine());
            int[] a = new int[1024];
            int[] f = new int[1024];
            int i = 0;
            int g = 0;
            Console.WriteLine("Razmer massiva");
            int h = Convert.ToInt16(Console.ReadLine());
            for (int d = 0; d < h; d++)
            {
                a[d]=Convert.ToInt16(Console.ReadLine());
            }
            for (int j = 0; j < h; j++)
            {
                if (a[j] > min)
                {
                    f[i] = a[j];
                    i++;
                    g = i;
                }
            }
            int t = f[0];
            for (i = 0; i < g; i++)
            {
                if (f[i] < t)
                {
                    t = f[i];
                }
            }
            Console.WriteLine(t);
        }
    }
}
