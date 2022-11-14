using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_13
    {
        int a;
        int b;
        int c;


        public void PrintRozwiazanieRowanania()
        {
            GetNumbersFromUser();
            Console.WriteLine(RozwiazRownanie());

        }


        private void GetNumbersFromUser()
        {
            Console.WriteLine("Równianie ax + b = c");
            Console.WriteLine("podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę c: ");
            c = int.Parse(Console.ReadLine());
        }


        private string RozwiazRownanie()
        {
            if (a == 0 && b != c)
            {
                return "To równanie nie ma rozwiązań";
            }
            else if (a == 0)
            {
                return "Rozwiązaniem tego równania jest każda liczba rzeczywista";
            }
            else
            {
                return $"Rozwiązaniem tego równania jest x = {(float)(c - b) / a}";
            }
        }
    }
}
