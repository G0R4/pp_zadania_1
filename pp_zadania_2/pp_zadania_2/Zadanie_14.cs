using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_2
{

    internal class Zadanie_14
    {


        public void PrintZadanieCzternaste()
        {
            bool dodatnie = true;

            Console.WriteLine("Podaj 10 liczb dodatnich");
            for (int i = 0; i < 10; i++)
            {
                if (int.Parse(Console.ReadLine()) <= 0)
                {
                    dodatnie = false;
                    break;
                }
            }

            if (dodatnie)
            {
                Console.WriteLine("SUKCES");
            }

        }
    }
}
