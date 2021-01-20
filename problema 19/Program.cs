using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). 
            // Determinati de cate ori apare p in s.
            // De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. 
            // (Problema este dificila doar daca o rezolvati cu un algoritm liniar).

            int n, l, i, j, ap;

            Console.WriteLine(" Cate elemente va avea vectorul principal s?");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] s = new int[n];

            for (i = 0; i < s.Length; i++)
            {
                Console.Write($" s[{i}] = ");
                s[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Cate elemente va avea vectorul pe care il cautati in s?");
            Console.Write(" l = ");
            l = int.Parse(Console.ReadLine());

            int[] p = new int[l];

            for (i = 0; i < p.Length; i++)
            {
                Console.Write($" p[{i}] = ");
                p[i] = int.Parse(Console.ReadLine());
            }

            ap = 0;

            for (i = 0; i < s.Length - p.Length; i++)
            {
                for (j = 0; j < p.Length && s[i + j] == p[j]; j++) { }
                if (j == l)
                    ap++;           
            }

            Console.WriteLine($"Vectorul p apare in vectorul s de {ap} ori.");

        }
    }
}
