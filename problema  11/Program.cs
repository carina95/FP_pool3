using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema__11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se da un numar natural n. 
            // Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 

            int n, i, j;

            Console.WriteLine(" Acest program afiseaza toate nr prime mai mici sau egale cu n (Ciurul lui Eratostene. ");

            Console.Write(" Dati un numar natural n = ");
            n = int.Parse(Console.ReadLine()); 

            int[] v = new int[n + 1];

            Console.WriteLine($" Toate numerele naturale prime mai mici decat {n} sunt: ");

            for (i = 2; i <= n; i++)
            {
                if (v[i] == 0)
                {
                    Console.WriteLine($"  {i}  ");
                    for (j = i + i; j <= n; j = j + i)
                        v[j] = 1;
                }
            }
        }
    }
}
