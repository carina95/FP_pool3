using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quicksort. Sortati un vector folosind metoda QuickSort. 

            int n, i;

            Console.WriteLine(" Cate elemente va avea vectorul? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (i = 0; i < v.Length; i++)
            {
                Console.Write($" v [{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }

            quickSort(v, 0, v.Length - 1);

            Console.WriteLine("Vectorul sortat prin quick-sort este:");

            printVector(v);
            
            mergeSort(x, 0, x.Length - 1);

            Console.WriteLine("Vectorul sortat prin merge-sort este:");
            
            printVector(x);
        }

        static void printVector(int[] v)
        {
            Console.Write($"{v[0]}");

            for (int i = 1; i < v.Length; i++)
                Console.Write($", {v[i]}");

            Console.WriteLine();
        }

        static void merge(int[] v, int l, int m, int r)
        {
            int sizeL = m - l + 1, sizeR = r - m;
            int[] L = new int[sizeL + 1];
            int[] R = new int[sizeR + 1];

            for (int i = 0; i < sizeL; i++)
                L[i] = v[l + i];
            for (int i = 0; i < sizeR; i++)
                R[i] = v[m + 1 + i];

            L[L.Length - 1] = int.MaxValue;
            R[R.Length - 1] = int.MaxValue;

            for (int i = 0, j = 0, k = l; k <= r; k++)
                v[k] = L[i] < R[j] ? L[i++] : R[j++];
        }
        static void mergeSort(int[] v, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;

                mergeSort(v, l, m);
                mergeSort(v, m + 1, r);
                merge(v, l, m, r);
            }
        }
        static int partition(int[] v, int l, int r)
        {
            int pivotIndex = l;

            for (int i = l; i < r; i++)
                if (v[i] < v[r])
                    pivotIndex++;
            (v[pivotIndex], v[r]) = (v[r], v[pivotIndex]);

            return pivotIndex;
        }
        static void quickSort(int[] v, int l, int r)
        {
            if (l < r)
            {
                int pi = partition(v, l, r);
                quickSort(v, l, pi - 1);
                quickSort(v, pi + 1, r);
            }
        }
    }
}
