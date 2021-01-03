using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. 
            // Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 

            int n, i, aux;

            Console.WriteLine(" Cate elemente va avea vectorul? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for(i = 0; i < n; i++)
            {
                Console.Write($" v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }

            aux = v[0];

            for(i = 0; i < n - 1; i++)
            {
                v[i] = v[i + 1];
            }

            v[n - 1] = aux;

            Console.WriteLine(" Dupa operatia de rotire vectorul este ");
            for(i = 0; i < n ; i++)
            {
                Console.Write($" v[{i}] = {v[i]} ");
            }
        }
    }
}
