using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_16
    {

        int a;
        int b;
        int i;
        public void PrintWypiszCiagLiczbGdzieKrancoweLiczbySaPodanePrzezUzytkownika()
        {
            GetNumbersFromUser();
            Console.WriteLine(WypiszCiagLiczbGdzieKrancoweLiczbySaPodanePrzezUzytkownika());
        }
        private void GetNumbersFromUser()
        {
            Console.WriteLine("podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());
        }
        private int WypiszCiagLiczbGdzieKrancoweLiczbySaPodanePrzezUzytkownika()
        {
            Console.WriteLine();
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }

            return i;
        }

    }
}
