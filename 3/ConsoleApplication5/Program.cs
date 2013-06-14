using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program { static void Main(string[] args) 
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7 }; 
        Masorybka(array); foreach (var i in array) 
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }
        private static void Masorybka(int[] mass) 
        { 
            int dlina = mass.Length - 1; 
            int delta = 0; if ((dlina & 1) == 0) 
            { 
                for (int i = 0; i < mass.Length - 1; i++) 
                { 
                    if ((mass.Length - 1) / 2 <= i) continue;
                    dlina -= delta; int temp = mass[i]; 
                    mass[i] = mass[dlina]; mass[dlina] = temp;
                    if (i == 0) delta = 1; 
                } 
            } 
            else 
            { 
                for (int i = 0; i < mass.Length - 1; i++) 
                { 
                    if ((mass.Length - 1) / 2 + 1 <= i) continue; 
                    dlina -= delta; int temp = mass[i]; 
                    mass[i] = mass[dlina]; 
                    mass[dlina] = temp; 
                    if (i == 0) delta = 1; 
                } 
            } 
        } 
    }
}
