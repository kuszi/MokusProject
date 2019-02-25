using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetvegiLenyoTomb
{
    class Program
    {//vegyél fel egy 20 elemű tömböt, és töltsd fel 0-19-ig. 
        static void Main(string[] args)
        {
            int[] block = new int[20];
            int n = block.Length;
            int i = 0;
            int alsoIndex = 0;
            int felsoIndex = n - 1;
            double osszeg = (alsoIndex + felsoIndex);
            double osszegfele = osszeg / 2;
            double kerekites = Math.Floor(osszegfele);
            int iKerekites = (int)kerekites;

            int stepCounter;

            for (i = 0; i < n; i++)
            {
                block[i] = i * 10;
                Console.Write($"{block[i]}, ");
            }

            do
            {
                Console.WriteLine($"\n A tömb also indexe: {alsoIndex}.");
                Console.WriteLine($"A tömb felso indexe: {felsoIndex}.");

                //vedd az alsoIndex és felsoIndex összegének a felét és lefelé kerekítsd.
                osszeg = (alsoIndex + felsoIndex);
                osszegfele = osszeg / 2;
                kerekites = Math.Floor(osszegfele);

                Console.WriteLine($" Az alsoIndex és felsoIndex összegének a felét és lefelé kerekítsd.{kerekites}");
                iKerekites = (int)kerekites;
                if (block[iKerekites] == 130)
                {
                    Console.WriteLine($"Meg van a 130.");
                }
                else if (block[iKerekites] < 130)
                {
                    alsoIndex = iKerekites;
                    Console.WriteLine($"A tömb alsóindexe elem: {alsoIndex}.");
                }
                else
                {
                    felsoIndex = iKerekites;
                    Console.WriteLine($"A tömb felsoindexe elem: {felsoIndex}.");
                }                
            }
            while (alsoIndex == felsoIndex || block[iKerekites] != 130);
           
            Console.ReadKey();

            #region régi
        //      class Program
        //{//vegyél fel egy 20 elemű tömböt, és töltsd fel 0-19-ig. 
            //static void Main(string[] args)
            //{
            //    int[] block = new int[20];
            //    int n = block.Length;
            //    int i = 0;
            //    int alsoIndex = 0;
            //    int felsoIndex = n - 1;
            //    double osszeg = (alsoIndex + felsoIndex);
            //    double osszegfele = osszeg / 2;
            //    double kerekites = Math.Floor(osszegfele);
            //    int iKerekites = (int)kerekites;

            //    int stepCounter;

            //    for (i = 0; i < n; i++)
            //    {
            //        block[i] = i * 10;
            //        Console.Write($"{block[i]}, ");
            //    }

            //    do
            //    {
            //        Console.WriteLine($"\n A tömb also indexe: {alsoIndex}.");
            //        Console.WriteLine($"A tömb felso indexe: {felsoIndex}.");

                    //vedd az alsoIndex és felsoIndex összegének a felét és lefelé kerekítsd.
                    //osszeg = (alsoIndex + felsoIndex);
                    //osszegfele = osszeg / 2;
                    //kerekites = Math.Floor(osszegfele);

                    //Console.WriteLine($" Az alsoIndex és felsoIndex összegének a felét és lefelé kerekítsd.{kerekites}");
                    //iKerekites = (int)kerekites;
                    //if (block[iKerekites] == 130)
                    //{
                    //    Console.WriteLine($"Meg van a 130."); break;
                    //}
                    //else if (block[iKerekites] < 130)
                    //{
                    //    alsoIndex = iKerekites;
                    //    Console.WriteLine($"A tömb alsóindexe elem: {alsoIndex}.");
                    //}
                    //else
                    //{
                    //    felsoIndex = iKerekites;
                    //    Console.WriteLine($"A tömb felsiindexe elem: {felsoIndex}.");
                    //}
                    //        l. if 9 == 13
                    //            - ha egyezik, akkor itt a keresés vége
                    //            - ha kissebb, akkor az alsoIndex kapja meg ezt az értéket. alsoIndex = 9-- most ez a helyzet
                    //-ha nagyobb, akkor a felsoIndex kapja meg ezt az értéket. felsoIndex = 9

                    //if (block[iKerekites] == 130)
                    //{
                    //    Console.WriteLine($"Meg van a 130.");
                    //}
                    //else if (block[iKerekites] < 130)
                    //{
                    //    alsoIndex = iKerekites;
                    //    Console.WriteLine($"A tömb alsóindexe elem: {alsoIndex}.");
                    //}
                    //else
                    //{
                    //    felsoIndex = iKerekites;
                    //    Console.WriteLine($"A tömb felsiindexe elem: {felsoIndex}.");
                    //}
                //}
                //while (block[alsoIndex] == block[felsoIndex] || block[alsoIndex] != 130);
                //{
                //    osszeg = (alsoIndex + felsoIndex);
                //    osszegfele = osszeg / 2;
                //    kerekites = Math.Floor(osszegfele);

                //    Console.WriteLine($" Az alsoIndex és felsoIndex összegének a felét és lefelé kerekítsd.{kerekites}");
                //    iKerekites = (int)kerekites;
                //    if (block[iKerekites] == 130)
                //    {
                //        Console.WriteLine($"Meg van a 130.");
                //    }
                //    else if (block[iKerekites] < 130)
                //    {
                //        alsoIndex = iKerekites;
                //        Console.WriteLine($"A tömb alsóindexe elem: {alsoIndex}.");
                //    }
                //    else
                //    {
                //        felsoIndex = iKerekites;
                //        Console.WriteLine($"A tömb felsiindexe elem: {felsoIndex}.");
                //    }
                //}


                //if (alsoIndex == felsoIndex && block[alsoIndex] != 130)
                //{
                //    Console.WriteLine($"Vége: nincs találat.");
                //}
                //else
                //{
                //    if (block[iKerekites] == 130)
                //    {
                //        Console.WriteLine($"Meg van a 130.");
                //    }
                //    else if (block[iKerekites] < 130)
                //    {
                //        alsoIndex = iKerekites;
                //        Console.WriteLine($"A tömb alsóindexe elem: {alsoIndex}.");
                //    }
                //    else
                //    {
                //        felsoIndex = iKerekites;
                //        Console.WriteLine($"A tömb felsiindexe elem: {felsoIndex}.");
                //    }

                //     osszeg = (alsoIndex + felsoIndex);
                //     osszegfele = osszeg / 2;
                //     kerekites = Math.Floor(osszegfele);

                //    Console.WriteLine($" Az alsoIndex és felsoIndex összegének a felét és lefelé kerekítsd.{kerekites}");
                //    iKerekites = (int)kerekites;
                //}


                //következő kör
                //osszeg = (alsoIndex + felsoIndex);
                //osszegfele = osszeg / 2;
                //kerekites = Math.Floor(osszegfele);

                //Console.WriteLine($" Az alsoIndex és felsoIndex összegének a felét és lefelé kerekítsd.{kerekites}");
                //iKerekites = (int)kerekites;

                //if (block[iKerekites] == 130)
                //{
                //    Console.WriteLine($"Meg van a 130.");
                //}
                //else if (block[iKerekites] < 130)
                //{
                //    alsoIndex = iKerekites;
                //    Console.WriteLine($"A tömb alsóindexe elem: {alsoIndex}.");
                //}
                //else
                //{
                //    felsoIndex = iKerekites;
                //    Console.WriteLine($"A tömb felsiindexe elem: {felsoIndex}.");
                //}

                //osszeg = (alsoIndex + felsoIndex);
                //osszegfele = osszeg / 2;
                //kerekites = Math.Floor(osszegfele);

                //Console.WriteLine($" Az alsoIndex és felsoIndex összegének a felét és lefelé kerekítsd.{kerekites}");
                //iKerekites = (int)kerekites;

                //if (block[iKerekites] == 130)
                //{
                //    Console.WriteLine($"Meg van a 130.");
                //}
                //else if (block[iKerekites] < 130)
                //{
                //    alsoIndex = iKerekites;
                //    Console.WriteLine($"A tömb alsóindexe elem: {alsoIndex}.");
                //}
                //else
                //{
                //    felsoIndex = iKerekites;
                //    Console.WriteLine($"A tömb felsiindexe elem: {felsoIndex}.");
                //}

                //osszeg = (alsoIndex + felsoIndex);
                //osszegfele = osszeg / 2;
                //kerekites = Math.Floor(osszegfele);

                //Console.WriteLine($" Az alsoIndex és felsoIndex összegének a felét és lefelé kerekítsd.{kerekites}");
                //iKerekites = (int)kerekites;

                //if (block[iKerekites] == 130)
                //{
                //    Console.WriteLine($"Meg van a 130.");
                //}
                //else if (block[iKerekites] < 130)
                //{
                //    alsoIndex = iKerekites;
                //    Console.WriteLine($"A tömb alsóindexe elem: {alsoIndex}.");
                //}
                //else
                //{
                //    felsoIndex = iKerekites;
                //    Console.WriteLine($"A tömb felsiindexe elem: {felsoIndex}.");
                //}

                //osszeg = (alsoIndex + felsoIndex);
                //osszegfele = osszeg / 2;
                //kerekites = Math.Floor(osszegfele);

                //Console.WriteLine($" Az alsoIndex és felsoIndex összegének a felét és lefelé kerekítsd.{kerekites}");
                //iKerekites = (int)kerekites;

                //if (block[iKerekites] == 130)
                //{
                //    Console.WriteLine($"Meg van a 130.");
                //}
                //else if (block[iKerekites] < 130)
                //{
                //    alsoIndex = iKerekites;
                //    Console.WriteLine($"A tömb alsóindexe elem: {alsoIndex}.");
                //}
                //else
                //{
                //    felsoIndex = iKerekites;
                //    Console.WriteLine($"A tömb felsiindexe elem: {felsoIndex}.");
                //}

                //vége
                //if (alsoIndex == felsoIndex && block[alsoIndex] != 130)
                //{
                //    Console.WriteLine($"Vége: nincs találat.");

                //}

            //    Console.ReadKey();
            //}
            #endregion
        }
    }
}
