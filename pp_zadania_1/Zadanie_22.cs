using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_22
    {
        public void PrintTabliczkaMnozenia()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}x{j} = {i*j}");
                }    
            }
             

        }
    }
}
