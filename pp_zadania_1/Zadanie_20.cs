using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_20
    {
        int licznik = 0;



        public void PrintIleLiczbParzystychZTysiacaPodanychPrzezUzytkownika()
        {
            for(int i = 0; i <= 1000; i++)
            {
                if (int.Parse(Console.ReadLine()) % 2 == 0)
                {
                    licznik++;
                }
            }
            Console.WriteLine($"Liczb parzystych jest {licznik}");
        }
    }
}
