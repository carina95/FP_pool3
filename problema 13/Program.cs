using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 

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

            for (i = 1; i < v.Length; i++)
            {
                for (k = i; k > 0 && v[k] < v[k - 1]; k--)
                {
                    aux = v[k];
                    v[k] = v[k - 1];
                    v[k - 1] = aux;
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
