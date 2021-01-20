using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_22
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // Se dau doi vectori v1 si v2. 
            // Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2-v1 
            // (implementarea operatiilor cu multimi). 
            // Elementele care se repeta vor fi scrise o singura data in rezultat. 

            int n, l, i, j;

            Console.WriteLine(" Cate elemente va avea vectorul v1 ?");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] v1 = new int[n];

            for (i = 0; i < v1.Length; i++)
            {
                Console.Write($" v1[{i}] = ");
                v1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Cate elemente va avea vectorul v2 ?");
            Console.Write(" l = ");
            l = int.Parse(Console.ReadLine());

            int[] v2 = new int[l];
            for (i = 0; i < v2.Length; i++)
            {
                Console.Write($" v2[{i}] = ");
                v2[i] = int.Parse(Console.ReadLine());
            }

            string s = "";

            for (i = 0; i < v1.Length; i++)
                for (j = 0; j < v2.Length; j++)
                    if (v1[i] == v2[j])
                        s += $" {v1[i]}, ";

            Console.WriteLine($" v1 intersectat cu v2 : {{ {s} }} ");

            string r = "";

            Console.WriteLine($" v1 reunit cu v2 : ");

            for ( j = 0; j < v2.Length; j++)
            {
                for ( i = 0; i < v1.Length; i++)
                    if (v1[j] != 0 && v2[j] != 0)
                        Console.Write(j + " ");
            }
        }
    }
}
