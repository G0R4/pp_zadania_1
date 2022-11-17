using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_21
    {

        int h;


        public void PrintPolChoinka()
        {
            GetNumberFromUser();
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }

            private void GetNumberFromUser()
            {
                Console.WriteLine("podaj wysokość choinki h: ");
                h = int.Parse(Console.ReadLine());
            }
        
           
        
        
    }
}
