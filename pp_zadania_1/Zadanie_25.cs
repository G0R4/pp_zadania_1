using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{

    internal class Zadanie_25
    {
        int suma = 0;
        string liczba;
        

        public void PrintDowolnaIloscLiczbSuma()
        {
            liczba = Console.ReadLine();
            while (liczba != "STOP")
            {               
                suma += int.Parse(liczba);
                liczba = Console.ReadLine();
            }
            Console.WriteLine($"Suma liczb wynosi {suma}");
        }
    }
}
