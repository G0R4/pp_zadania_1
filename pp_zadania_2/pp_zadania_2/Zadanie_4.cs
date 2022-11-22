using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_2
{
    internal class Zadanie_4
    {
        string[] imiona = new string[10];
        public void PrintWitajImiona()
        {
            Console.WriteLine("Podaj 10 imion: ");
            for (int i = 0; i < imiona.Length; i++)
            {
                imiona[i] = Console.ReadLine();
            }
            Console.WriteLine("Witajcie: ");
             for(int i = 0; i < imiona.Length; i++)
             {
                Console.Write(imiona[i]);
                if (i != imiona.Length - 1)
                    Console.Write(", ");
                else
                    Console.Write(".");

             }
        }
    }
}
