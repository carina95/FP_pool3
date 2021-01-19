using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 

            int n, i, j, k, l;

            Console.WriteLine(" Cate elemente va avea vectorul? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            for (i = 0; i < n - 1; i++)
            {
                Console.Write($" v[{i}] =  ");
                v[i] = int.Parse(Console.ReadLine());
            }

            l = n; //lungimea vectorului

            for (i = 0; i < l - 1; i++)
            {
                for(j = i + 1; j < l; j++)
                {
                    if (v[i]==v[j])
                    {
                        for (k = j + 1; k < l; k++)
                            v[k - 1] = v[k];
                        l--;
                        j--;
                    }
                }
            }
            Console.WriteLine(" Vectorul fara elemente care se repeta este: "); 
            for(i = 0; i < l; i++)
                Console.Write($" {v[i]}  ");
            Console.WriteLine();
        }
    }
}
