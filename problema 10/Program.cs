using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_10
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. 
            // Se cere sa se determine pozitia unui element dat k. 
            // Daca elementul nu se gaseste in vector rezultatul va fi -1.

            int n, i, j, aux, k;

            Console.WriteLine(" Cate elemente va avea vectorul? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write($" v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
            Console.WriteLine(" Vectorul sortat in ordine crescatoare este: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($" {v[i]} ");
            }

            Console.Write(" k = ");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine($" Prin cautarea binara, elementul {k} este pe pozitia {cautarebinara(v, k)} ");
        }
        private static int cautarebinara(int[] v, int k)
        {
            int m, s, d;
            s = 0;
            d = v.Length - 1; 
            m = s + (d - s) / 2;
            while (s < d)
            {
                if (k == v[m])
                    return m;
                if (k < v[m])
                   d = m - 1;
                else
                   s = m + 1;
            }
        return -1;
        }
    }
}


