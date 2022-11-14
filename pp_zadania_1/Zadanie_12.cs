using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_12
    {
        float a;
        float b;
        float c;


        public void PrintCzyTrojkatProstokatny()
        {
            GetNumbersFromUser();
            Console.WriteLine(CzyTrojkatJestProstokatny());

        }


        private void GetNumbersFromUser()
        {
            
            Console.WriteLine("podaj pierwszą przyprostokątną trójkąta: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj drugą przyprostokątną trójkąta: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj przeciwprostokątną trójkąta: ");
            c = float.Parse(Console.ReadLine());
        }


        private string CzyTrojkatJestProstokatny()
        {
            if (a*a + b*b == c*c || a*a + c*c == b*b || b*b + c*c == a*a)
            {
                return "Trójkąt z podanymi bokami jest prostokątny"; 
            }
            else
            {
                return "Trójkąt z podanymi bokami nie jest prostokątny";
            }

        }
    }
    
} 
