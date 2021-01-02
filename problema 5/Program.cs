using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se da un vector cu n elemente, o valoare e si o pozitie din vector k. 
            // Se cere sa se insereze valoarea e in vector pe pozitia k. 
            // Primul element al vectorului se considera pe pozitia zero. 

            int n, i, e, k;
           
            Console.WriteLine(" Cate elemente va avea vectorul? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());
 
            int[] v = new int[n+1];

            for (i = 0; i <= n ; i++)
            {
                Console.Write($" v [{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Dati o valoare e: ");
            Console.Write(" e = ");
            e = int.Parse(Console.ReadLine());

            Console.WriteLine(" Dati o pozitie k in vector: ");
            Console.Write(" k = ");
            k = int.Parse(Console.ReadLine());

            for (i = n -1; i > k; i--)
            {
                v[i] = v[i + 1];
            }

            n = n + 1;
            v[k] = e;

            Console.WriteLine(" Vectorul este: ");
            for(i = 0; i < n ; i++)
            {
                Console.WriteLine($"{v[i]}");
            }      
            
        }
    }
}
