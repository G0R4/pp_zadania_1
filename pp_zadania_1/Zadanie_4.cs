using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_4
    {
        int a;
        int b;
        public void PrintSumaDwochLiczb()
        {
            GetNumbersFromUser();
            Console.WriteLine(SumNumbers());
        }

        private void GetNumbersFromUser()
        {
            Console.WriteLine("Podaj liczbę: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            b = int.Parse(Console.ReadLine());
        }

        private int SumNumbers()
        {
            return a + b;
        }
    }
}
