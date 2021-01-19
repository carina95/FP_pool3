using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interschimbati elementele unui vector in asa fel incat 
            //la final toate valorile egale cu zero sa ajunga la sfarsit.
            //(nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient -
            //se va face o singura parcugere a vectorului). 

            int n, i, z;

            Console.WriteLine(" Cate elemente va avea vectorul? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (i = 0; i < v.Length; i++)
            {
                Console.Write($" v [{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }
     
            z = 0;

            for (i = 0; i < v.Length - z; i++)
            {
                if (v[i] == 0)
                {
                    v[i] = v[v.Length - 1 - z];
                    v[v.Length - 1 - z] = 0;
                    z++;
                }
            }

            Console.WriteLine(" Vectorul schimbat este: ");

            for (i = 0; i < v.Length; i++)
            {
                Console.Write($" {v[i]} ");
            }

            Console.WriteLine();
        }
    }
}
