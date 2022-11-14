using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_zadania_1
{
    internal class Zadanie_11
    {
        int a;
        int b;
        int c;


        public void PrintLiczbyOdNajmniejszejDoNajwiekszej()
        {
            GetNumbersFromUser();
            int[] SortedTab = SzeregujLiczbyOdNajmniejszejDoNajwiekszej();
            Console.WriteLine();
            for (int i = 0; i < SortedTab.Length; i++)
            {
                Console.WriteLine(SortedTab[i]);
            }
        }


        private void GetNumbersFromUser()
        {
            Console.WriteLine("podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę c: ");
            c = int.Parse(Console.ReadLine());
        }


        private int[] SzeregujLiczbyOdNajmniejszejDoNajwiekszej()
        {
            int[] tab = new int[3];          
          
            if (a <= b && a <= c)
            {
                tab[0] = a;
                if (b <= c)
                {
                    tab[1] = b;
                    tab[2] = c;
                }
                else
                {
                    tab[1] = c;
                    tab[2] = b;
                }
            }
            else if (b <= a && b <= c)
            {
                tab[0] = b;
                if (a <= c)
                {
                    tab[1] = a;
                    tab[2] = c;
                }
                else
                {
                    tab[1] = c;
                    tab[2] = a;
                }
            }
            else
            {
                tab[0] = c;
                if (a <= b)
                {
                    tab[1] = a;
                    tab[2] = b;
                }
                else
                {
                    tab[1] = b;
                    tab[2] = a;
                }

            }
            return tab;
            
        }
        
    }
}