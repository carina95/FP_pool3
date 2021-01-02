using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. 

            int n, i, mare, mic, min, max;
            int[] v = new int[100];

            Console.WriteLine(" Cate elemente va avea vectorul? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());
                        
            for (i = 0; i <= n -1; i++)
            {
                Console.Write($" v [{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }    

            min = v[0];
            mic = 0; //poz el mic

            max = v[0];
            mare = 0; //poz el mare

            for(i = 1; i <= n - 1; i++)
            {
                if (v[i] < min)
                {
                    min = v[i];
                    mic = i;
                }     

                if (v[i] > max)
                {
                    max = v[i];
                    mare = i;
                }
            }       
            
            Console.WriteLine($" Pozitia celui mai mic element din vector este {mic}. ");

            Console.WriteLine($" Pozitia celui mai mare element din vector este {mare}. ");
        }
    }
}
