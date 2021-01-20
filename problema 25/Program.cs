using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_25
{
    class Program
    {
        static void Main(string[] args)
        {
            // (Interclasare)Se dau doi vector sortati crescator v1 si v2. 
            // Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2.
            // sunt permise elemente duplicate. 

            int n, l, i, j, k, p, q, r;

            Console.WriteLine(" Cate elemente va avea vectorul v1 ?");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] v1 = new int[n];

            for (i = 0; i < v1.Length; i++)
            {
                Console.Write($" v1[{i}] = ");
                v1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Cate elemente va avea vectorul v2 ?");
            Console.Write(" l = ");
            l = int.Parse(Console.ReadLine());

            int[] v2 = new int[l];
            for (i = 0; i < v2.Length; i++)
            {
                Console.Write($" v2[{i}] = ");
                v2[i] = int.Parse(Console.ReadLine());
            }
            q = n + l;
            int[] v3 = new int[q];

            r = 0;
            j = 0;
            k = 0;

            while (r < n && j < l)
            {
                if (v1[r] < v2[j])
                {
                    v3[k] = v1[r];
                    k++;
                    r++;
                }
                else
                {
                    v3[k] = v2[j];
                    k++;
                    j++;
                }
            }

            if (r < n)
            {
                for (p = l; p < n; p++)
                {
                    v3[k] = v1[p];
                    k++;
                }
            }
            if (j < l)
            {
                for (p = j; p < l; p++)
                {
                    v3[k] = v2[p];
                    k++;
                }
            }

            Console.WriteLine("Dupa interclasare, noul vector este: ");

            for (k = 0; k < q; k++)
            {
                Console.Write ($" {v3[k]}   ");
            }
            Console.WriteLine();
        }
    }
}

    
