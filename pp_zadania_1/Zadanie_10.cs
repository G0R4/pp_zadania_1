using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_10
    {
        int n;


        public void PrintLiczbaParzystaNieparzysta()
        {
            GetNumberFromUser();
            Console.WriteLine(LiczbaParzystaNieparzysta());
        }


        private void GetNumberFromUser()
        {
            Console.WriteLine("podaj liczbę n: ");
            n = int.Parse(Console.ReadLine());

        }


        private string LiczbaParzystaNieparzysta()
        {           
            if (n % 2 == 0)
                return $"Liczba {n} jest parzysta";
            else
                return $"Liczba {n} jest nieparzysta";
        }
    }
} 
