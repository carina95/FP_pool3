using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 

            int n, i, j, k, aux;

            Console.WriteLine(" Cate elemente va avea vectorul? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for(i = 0; i < n; i++)
            {
                Console.Write($" v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Cu cate pozitii doriti sa rotiti elementele vectorului? ");
            Console.Write(" k = ");
            k = int.Parse(Console.ReadLine());

            for(i = 1; i <= k; i++)
            {
                aux = v[0];
                for (j = 0; j < n -1; j++)
                {
                    v[j] = v[j+1];
                }
                v[n - 1] = aux;
            }

            Console.WriteLine(" Dupa rotire, vectorul este: ");
            for( i = 0; i < n; i++)
            {
                Console.WriteLine($" v[{i}] = {v[i]} ");
            }
        }
        
    }
}
