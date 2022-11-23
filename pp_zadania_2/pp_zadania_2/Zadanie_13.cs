using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_2
{
    internal class Zadanie_13
    {
        int n;
        bool jest_potega = true;


        public void PrintZadanieTrzynaste()
        {
            
            Console.WriteLine("Podaj liczbę");
            n = int.Parse(Console.ReadLine());

            while (n > 1)
            {
                if (n % 2 != 0)
                {
                    jest_potega = false;
                    break;
                }
                n /= 2;
            }

            if (jest_potega)
            {
                Console.WriteLine("Jest potęgą dwójki");
            }
            else
            {
                Console.WriteLine("Nie jest potęgą dwójki");
            }

        }
    }
}
