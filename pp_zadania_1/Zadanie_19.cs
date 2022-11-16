using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_19
    {
        int licznik = 0;
        public void PrintIleLiczbParzystychZDziesieciuPodanychPrzezUzytkownika()
        {
            
            for (int i = 0; i < 10; i++)
            {
                if (int.Parse(Console.ReadLine()) % 2 == 0)
                {
                    licznik++;
                }    
            }    
            Console.WriteLine($"Liczb Parzystych jest {licznik}");
            
        }
    }
}
