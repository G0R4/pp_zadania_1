using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_2
{
    internal class Zadanie_1
    {
        int[] liczby = new int[10];
        int i;

        public void PrintLiczbyWOdwrotnejKolejnosci()
        {
            GetNumbersFromUser();
            Console.WriteLine(OdwrocKolejnoscLiczb());
        }
        private void GetNumbersFromUser()
        {
            Console.WriteLine("Podaj 10 liczb:");
            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = int.Parse(Console.ReadLine());
            }
            for (int i = liczby.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(liczby[i]);
            }

        }
        private int OdwrocKolejnoscLiczb()
        {           
            {
                return (" ");
            }

        }
    }
}
