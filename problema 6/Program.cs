using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente si o pozitie din vector k. 
            //Se cere sa se stearga din vector elementul de pe pozitia k.
            //Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 

            int n, i, k, e;

            Console.WriteLine(" Cate elemente va avea vectorul? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for( i = 0; i < n; i++)
            {
                Console.Write($" v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Introduceti pozitia k.");
            Console.Write(" k = ");
            k = int.Parse(Console.ReadLine());

            for (i = k; i < n - 1 ; i++)
            {
                v[i] = v[i + 1];
            }

            Console.WriteLine(" Noul vector este: ");
            for (i = 0; i < n - 1; i++)
            {
                Console.WriteLine($" v[{i}] = {v[i]} ");
            }
        }
    }
}
