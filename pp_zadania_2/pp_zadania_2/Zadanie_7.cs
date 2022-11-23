using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_2
{
    internal class Zadanie_7
    {
        public void PrintSredniaArytmetycznaLiczbPodawanychAzDoStop()
        {
            float suma = 0;
            int liczba = 0;
            string input;

            Console.WriteLine("Podaj liczby. Wpisz STOP aby zakończyć.");
            input = Console.ReadLine();
            while (input != "STOP")
            {
                suma += float.Parse(input);
                liczba++;
                input = Console.ReadLine();
            }

            Console.WriteLine(suma / liczba);

        }
    }
}
