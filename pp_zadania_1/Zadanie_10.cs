using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_10
    {
        int a;
        public void PrintLiczbaParzystaNieparzysta()
        {
            GetNumberFromUser();
            Console.WriteLine(LiczbaParzystaNieparzysta());
        }
        private void GetNumberFromUser()
        {
            Console.WriteLine("podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());

        }
        private int LiczbaParzystaNieparzysta()
        {
            if (a % 2 == 0)
            {
                return Console.WriteLine($"Liczba {a} jest parzysta");
            }
            else
            {
                return Console.WriteLine($"Liczba {a} jest nieparzysta");
            }
        }
    }
}
