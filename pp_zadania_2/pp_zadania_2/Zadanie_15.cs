using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_2
{
    internal class Zadanie_15
    {
        bool sukces = true;

        public void PrintZadaniePietnaste()
        {
            
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i}x{j}=");
                    int wynik = int.Parse(Console.ReadLine());
                    if (wynik != i * j)
                    {
                        Console.WriteLine("SPRÓBUJ JESZCZE RAZ");
                        sukces = false;
                        break;
                    }
                }
                if (!sukces) break;
            }

            if (sukces) Console.WriteLine("SUKCES");

        }
    }
}
