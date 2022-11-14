using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_14
    {
        int a;



        public void PrintCzyLiczbaJestDodatniaZeremUjemna()
        {
            GetNumberFromUser();
            Console.WriteLine(CzyLiczbaJestDodatniaZeremUjemna());
        }




        private void GetNumberFromUser()
        {
            Console.WriteLine("podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
        }



        private string CzyLiczbaJestDodatniaZeremUjemna()
        {
            if (a > 0)
            {
                return "1";
            }
            else if (a == 0)
            {
                return "0";
            }
            else
            {
                return "-1";
            }
        }
    }
}
