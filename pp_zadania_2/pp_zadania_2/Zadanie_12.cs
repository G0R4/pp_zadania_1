using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_2
{
    internal class Zadanie_12
    {


        public void PrintKolkoIKrzyzykTrzy()
        {
            string[,] plansza = new string[3, 3];
            for (int i = 0; i < 3; i++) for (int j = 0; j < 3; j++) plansza[i, j] = " ";

            for (int tura = 0; tura < 9; tura++)
            {
                string gracz = tura % 2 == 0 ? "X" : "O";
                Console.WriteLine($"Tura gracza {gracz}");

                int x, y;

                do
                {
                    Console.WriteLine("Wybierz pole:");
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                    if (plansza[x, y] != " ") Console.WriteLine("Pole zajęte!");
                } while (plansza[x, y] != " ");

                plansza[x, y] = gracz;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++) Console.Write($"[{plansza[i, j]}]");
                    Console.WriteLine();
                }

                string zwyciezca = "";
                if (plansza[0, 0] == gracz && plansza[1, 1] == gracz && plansza[2, 2] == gracz)
                    zwyciezca = gracz;
                if (plansza[0, 2] == gracz && plansza[1, 1] == gracz && plansza[2, 0] == gracz)
                    zwyciezca = gracz;
                for (int i = 0; i < 3; i++)
                {
                    if (plansza[i, 0] == gracz && plansza[i, 1] == gracz && plansza[i, 2] == gracz)
                        zwyciezca = gracz;
                    if (plansza[0, i] == gracz && plansza[1, i] == gracz && plansza[2, i] == gracz)
                        zwyciezca = gracz;
                }
                if (zwyciezca != "")
                {
                    Console.WriteLine($"Zwycięża gracz {zwyciezca}");
                    break;
                }
            }

        }
    }
}
