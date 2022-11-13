using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_9
    {
        int a;
        public void PrintLiczbaParzysta()
        {
                GetNumberFromUser();
                Console.WriteLine(LiczbaParzysta());
        }
        private void GetNumberFromUser()
        {
            Console.WriteLine("podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
            
        }
        private int LiczbaParzysta()
        {
             if (a % 2 == 0)
            {
                return Console.WriteLine($"Liczba {a} jest parzysta");
            }
              
        } 
     

    }
}
