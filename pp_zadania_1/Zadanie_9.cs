using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_9
    {
        int n;


        public void PrintLiczbaParzysta()
        {
                GetNumberFromUser();
                Console.WriteLine(CzyLiczbaParzysta());
        }


        private void GetNumberFromUser()
        {
            Console.WriteLine("podaj liczbę n: ");
            n = int.Parse(Console.ReadLine());
            
        }


        private string CzyLiczbaParzysta()
        {
            n.ToString();
            if (n % 2 == 0)
                return $"Liczba {n} jest parzysta";
            else
                return null;
        } 
     

    }
} 
