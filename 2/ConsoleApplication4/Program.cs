using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");
            int i, j, s;
            s = int.Parse(Console.ReadLine());
            int[] mas = new int[s];
            Console.Write("Введите " + s); 
            Console.WriteLine(" элементов массива: ");

            for (i = 0; i < s; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < s - 1; i++)
            {
                for (j = i + 1; j < s; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int taas = mas[i];
                        mas[i] = mas[j];
                        mas[j] = taas;
                    }
                }
            }
            Console.WriteLine();
                                    
            foreach(int x in mas)
             Console.WriteLine(x);

                    
                Console.ReadLine();

        
        }
    }
}
