using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreHazi_Logika
{
    class Szamolasok
    {
        // 1. Írd ki a számokat 1-től 10-ig.
        public void SzamoljTizig()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}, ");
            }

        }
        //Ugyanaz mint az első, de csak a páros számokat írd ki. Elsőnek guglizz, ha nem találod meg hogy kell a páros számra csekkolni, akkor lejebb leírom.

        public void CsakParosSzamok()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}, ");
                }
            }

        }
        //1-100-ig kell kiíni a számokat, de 10 sorba. 

        public void EgytolSzazig()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine($"{i}, ");
                }
                else
                {
                    Console.Write($"{i}, ");
                }
            }

        }
        //Ugyanaz mint a 3-as, de csak a páratlan számokat kell kiírni :)

        public void EgytolSzazigParatlan()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    if (i % 9 == 0)
                    {
                        Console.WriteLine($"{i}, ");
                    }
                    else
                    {
                        Console.Write($"{i}, ");
                    }
                }
            }

        }
    }
}
