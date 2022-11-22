using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_2
{
    internal class Zadanie_5
    {
        float[] liczby = new float[10];     


        public void PrintSredniaArytmetycznaFloat()
        {
            Console.WriteLine("Podaj 10 liczb:");
            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = float.Parse(Console.ReadLine());
            }

            float suma = 0;
            for (int i = 0; i < liczby.Length; i++)
            {
                suma += liczby[i];
            }

            Console.WriteLine(suma / liczby.Length);

        }
    }
}
