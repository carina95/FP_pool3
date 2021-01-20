using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. 
            //Cel mai putin semnificativ coeficient este pe pozitia zero in vector. 
            //Se cere valoarea polinomului intr-un punct x. 

            int n, aux, x, polinom, i;
             
            Console.WriteLine(" Introduceti gradul n al polinomului. ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());
            aux = n;

            Console.WriteLine(" Introduceti punctul x ");
            Console.Write(" x = ");
            x = int.Parse(Console.ReadLine());

            int[] v= new int[n + 1];

            Console.WriteLine(" Introduceti coeficientii ");

            for (i = 0; i <= n; i++)
            { 
                Console.Write($" coeficientul {i} = ");
                v[i] = int.Parse(Console.ReadLine());
            }

            polinom = 0;

            for (i = 0; i < n + 1; i++)
            {
                polinom += v[i] * (int)(Math.Pow(x, aux));

                if (i < n)
                {
                    Console.Write($" {v[i]} * {x}^{aux} +");
                }
                else
                {
                    Console.Write($" {v[i]} * {x}^{aux}");
                }
                aux--; 
            }

            Console.Write($" = {polinom}. ");
            Console.WriteLine();

        }
    }
}
