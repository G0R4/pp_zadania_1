using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_2
{
    internal class Zadanie_9
    {
        List<float> liczby = new List<float>();
        string input;
        float iloczyn = 1;

        public void PrintZadanieDziewiate()
        {
            Console.WriteLine("Podaj liczby. Wpisz STOP aby zakończyć.");
            input = Console.ReadLine();
            while (input != "STOP")
            {

                liczby.Add(float.Parse(input));
                input = Console.ReadLine();
            }

            for (int i = 0; i < liczby.Count; i++)
            {
                iloczyn *= liczby[i];
            }

            Console.WriteLine(Math.Pow(iloczyn, 1.0 / liczby.Count));
        }
    }
}
