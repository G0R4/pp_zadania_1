using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_3
    {
        public void PrintWitajImie()
        {
            string imie;
            Console.WriteLine("Podaj swoję imię: ");
            imie = Console.ReadLine();
            Console.WriteLine($"Witaj {imie}!");
        }
    }
}
