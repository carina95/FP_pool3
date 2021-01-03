using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse. Se da un vector cu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
            //Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.

            int n, i, aux;

            Console.WriteLine(" Cate elemente va avea vectorul? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write($" v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }

            for(i = 0; i < n / 2; i++)
            {
                aux = v[i];
                v[i] = v[n - 1 - i];
                v[n - 1 - i] = aux;
            }

            Console.WriteLine(" Vectorul inversat este urmatorul: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($" v[{i}] = {v[i]}");
            }
        }
    }
}
