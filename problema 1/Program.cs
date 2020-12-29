using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculati suma elementelor unui vector de n numere citite de la tastatura. 
            //Rezultatul se va afisa pe ecran.

            int i, n, suma;
            int[] v = new int[100];

            Console.WriteLine(" Dati numarul de elemente al vectorului.");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            suma = 0;

            Console.WriteLine(" Introduceti elementele vectorului: ");

            for (i = 0; i <= n - 1; i++)
            {
                Console.Write(" v[{0}] = ", i);
                v[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i <= n; i++)
            {
                suma = suma + v[i];
            }

            Console.WriteLine($" Suma elementelor vectorului este {suma}. ");
        }
    }
}
