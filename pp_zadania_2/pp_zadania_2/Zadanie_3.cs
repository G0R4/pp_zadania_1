using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_2
{
    internal class Zadanie_3
    {
        int[] liczby = new int[10];

        public void PrintLiczbyNaMiejscachParzystych()
        {
            Console.WriteLine("Podaj 10 liczb:");
            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = int.Parse(Console.ReadLine());
            }          
            for (int i = 0; i < liczby.Length; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(liczby[i]);
            }

        }
    }
}
