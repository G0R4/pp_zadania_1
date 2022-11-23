using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_2
{

    internal class Zadanie_10
    {


        public void PrintKolkoIKrzyzyk()
        {
            string[,] plansza = new string[3, 3];
            for (int i = 0; i < 3; i++) for (int j = 0; j < 3; j++) plansza[i, j] = " ";

            for (int tura = 0; tura < 9; tura++)
            {
                string gracz = tura % 2 == 0 ? "X" : "O";
                Console.WriteLine($"Tura gracza {gracz}");

                Console.WriteLine("Wybierz pole:");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                plansza[x, y] = gracz;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++) Console.Write($"[{plansza[i, j]}");
                    Console.WriteLine();
                }

            }
        }
    }
}