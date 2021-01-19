using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 

            int n, i, k, j, aux;

            Console.WriteLine(" Cate elemente va avea vectorul? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (i = 0; i < v.Length; i++)
            {
                Console.Write($" v [{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < v.Length; i++)
            {
                k = i;
                for (j = i + 1; j < v.Length; j++)
                {
                    if (v[j] < v[k])
                        k = j;
                    aux = v[k];
                    v[k] = v[i];
                    v[i] = aux;
                }
            }

            Console.WriteLine(" Vectorul sortat este: ");

            for (i = 0; i < v.Length; i++)
            {
                Console.Write($" {v[i]} ");
            }
        }
    }
}

