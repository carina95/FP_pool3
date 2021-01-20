using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector de n numere naturale. 
            //Determinati cel mai mare divizor comun al elementelor vectorului.

            int n, i, aux, cmmdc;

            Console.WriteLine(" Cate elemente va avea vectorul?");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write($" v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }

            cmmdc = v[0];

            for(i = 1; i < n; i++)
            {
                aux = v[i];
                while(aux != cmmdc)
                {
                    if (aux > cmmdc)
                        aux = aux - cmmdc;
                    else
                        cmmdc = cmmdc - aux;
                }
            }
            Console.WriteLine($" Cel mai mare divizor comun al elementelor vectorului este {cmmdc}. ");
        }
    }
}
