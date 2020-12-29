using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente si o valoare k. 
            //Se cere sa se determine prima pozitie din vector pe care apare k. 
            //Daca k nu apare in vector rezultatul va fi -1. 

            int i, n, k, poz;
            int[] v = new int[100];

            Console.WriteLine(" Dati numarul de elemente al vectorului.");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write(" Dati k = ");
            k = int.Parse(Console.ReadLine());

            poz = -1;

            Console.WriteLine(" Introduceti elementele vectorului: ");

            for (i = 1; i <= n ; i++)
            {
                Console.Write(" v[{0}] = ", i);
                v[i] = int.Parse(Console.ReadLine());
            }

            for (i = 1; i <= n; i++)
            {
                if (v[i] == k)
                    poz = i;
            }

            Console.WriteLine($" Prima pozitie din vector pe care apare {k} este {poz}. ");
        }
    }
}
