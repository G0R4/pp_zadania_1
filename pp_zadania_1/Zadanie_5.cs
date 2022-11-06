using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_5
    {
        float a;
        float b;
        public void PrintAreaRectangle()
        {
            GetNumbersFromUser();
            Console.WriteLine(MultNumbers());
           
        }
        private void GetNumbersFromUser()
        {
            Console.WriteLine("podaj bok a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj bok b: ");
            b = float.Parse(Console.ReadLine());
        }
        private float MultNumbers()
        {
            return a * b;
        }
    }
}
