using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_24
    {
        int licznik = 0;
        string liczba;

        public void PrintDowolnaIloscLiczbIleParzystych()           
        {
            liczba = Console.ReadLine();
            while (liczba != "STOP")
            {
                if (int.Parse(liczba) % 2 == 0)
                {
                    licznik++;
                }
                liczba = Console.ReadLine();
            }
            Console.WriteLine($"Podano {licznik} liczb parzystych");

        }
    }
}
