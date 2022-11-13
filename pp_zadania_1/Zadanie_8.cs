using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_8
    {
        float a;
        float b;
        public void PrintWynikDzieleniaZReszta()
        {
            GetNumbersFromUser();
            Console.WriteLine(DzielenieLiczb());
        }
        private void GetNumbersFromUser()
        {
            Console.WriteLine("podaj liczbę a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę b: ");
            b = float.Parse(Console.ReadLine());
        }
        private float DzielenieLiczb()
        {
            return a / b;
        }
    }
}
