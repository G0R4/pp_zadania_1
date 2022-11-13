using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_7
    {
        int a;
        int b;
        public void PrintWynikDzieleniaBezReszty()
        {
            GetNumbersFromUser();
            Console.WriteLine(DzielenieLiczb());
        }
        private void GetNumbersFromUser()
        {
            Console.WriteLine("podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());
        }
        private int DzielenieLiczb()
        {
            return a / b;
        }
    }
}
