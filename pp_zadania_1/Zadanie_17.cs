using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_17
    {
        int a;
        int b;    

        public void PrintWypiszCoDrugaLiczbaGdzieKrancoweLiczbySaPodanePrzezUzytkownika()
        {
            GetNumbersFromUser();
            Console.WriteLine();
            for (int i = a; i <= b; i += 2)
            {
                Console.WriteLine(i);

            }
        }


        private void GetNumbersFromUser()
        {
            Console.WriteLine("podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());
        }
    }
} 

