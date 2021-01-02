using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare 
            // dintr-un vector si de cate ori apar acestea. 

            int n, i, min, max, contormin, contormax; 
            int[] v = new int[100]; 

            Console.WriteLine(" Cate elemente va avea vectorul? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            contormin = 1;
            contormax = 1;

            for (i = 0; i <= n - 1; i++)
            {
                Console.Write($" v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            } 

            max = v[0];
            min = v[0];

            for(i = 1; i <= n - 1; i++)
            { 
                if( v[i] > max)
                    max = v[i];
                else if ( v[i] == max)
                        contormax++;
                if ( v[i] < min)
                    min = v[i]; 
                else if ( v[i] == min)
                        contormin++;          
            }

             Console.WriteLine(" Maximul vectorului este {0} si apare de {1} ori. ", max, contormax);

             Console.WriteLine(" Minumul vectorului este {0} si apare de {1} ori. ", min, contormin);
        }
    }
}
