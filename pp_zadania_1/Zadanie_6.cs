using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_6
    {
        double r;
        public void PrintObjetoscKuli()
        {
            GetNumbersFromUser();
            Console.WriteLine(ObjNumbers());

        }
        private void GetNumbersFromUser()
        {
            Console.WriteLine("podaj r: ");
            r = double.Parse(Console.ReadLine());
        }

        private double ObjNumbers()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(r , 3);
        }

    }
}