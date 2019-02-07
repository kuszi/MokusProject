using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buborek894
{
    class Program
    {
        static void Main(string[] args)
        {
            #region regi
            //var seed = 25;//seed értéke
            //Random rnd = new Random(seed);//seed /ugyan azon random értékek
            //int[] block = new int[10];
            //int n = block.Length;
            //int kelott = 0;//ő lesz a kulcs elem, ha nem egyenlő a block[a] 894-el akkor k-t növelem
            //int kutan = 0;

            //kelott = RandomFixnumberBefore(rnd, block, n, kelott);

            //Console.WriteLine();
            ////Buborék rendezés
            //for (int i = n - 1; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (block[j] > block[j + 1])
            //        {
            //            int b = block[j + 1];
            //            block[j + 1] = block[j];
            //            block[j] = b;
            //        }
            //    }
            //}

            //Kiíratás rendezés után
            // kutan = FixRandomNumberAfter(block, n, kutan);

            //  Console.ReadKey();
            // }

            //private static int FixRandomNumberAfter(int[] block, int n, int kutan)
            //{
            //    for (int c = 0; c < n; c++)
            //    {
            //        //Console.Write("{0} ", block[c]);

            //        if (block[c] != 894)
            //        {
            //            kutan++;
            //        }

            //    }
            //    Console.WriteLine($"{kutan}. helyen áll.");
            //    return kutan;
            //}

            //private static int RandomFixnumberBefore(Random rnd, int[] block, int n, int kelott)
            //{
            //    for (int a = 0; a < n; a++)
            //    {
            //        block[a] = rnd.Next(0, 1000);
            //      //  Console.Write("{0} ", block[a]);
            //        if (block[a] != 894)
            //        {
            //            kelott++;
            //        }
            //        else
            //        {
            //            int k = 0;
            //            k = kelott;

            //            Console.Write($"{kelott}. helyen áll.");
            //        }

            //    }

            //    return kelott;
            //}

            #endregion

            #region refektor előtt, de amúgy nem jó CSaba amit mondasz mert kell még egy +1 hiszen nem a 3. és 8 helyen van

            //var seed = 25;
            //Random rnd = new Random(seed);
            //int[] block = new int[10];
            //int n = block.Length;

            //int k = 1;
            //int kk = 0;
            //int kkk = 0;


            ////Feltöltöm a tömböt random számokkal
            //for (int a = 0; a < n; a++)
            //{
            //    block[a] = rnd.Next(0, 1000);
            //    Console.Write("{0} ", block[a]);
            //    if (block[a] != 894)
            //    {
            //        k++;
            //    }
            //    else
            //    {
            //        kk = k;
            //    }

            //}

            //Console.WriteLine();
            //////Buborék rendezés
            //for (int i = n - 1; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (block[j] > block[j + 1])
            //        {
            //            int b = block[j + 1];
            //            block[j + 1] = block[j];
            //            block[j] = b;
            //        }
            //    }
            //}
            //k = 1;
            //for (int c = 0; c < n; c++)
            //{

            //    Console.Write("{0} ", block[c]);
            //    if (block[c] != 894)
            //    {
            //        k++;
            //    }
            //    else
            //    {
            //        kkk = k;
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine($"Rendezés előtt {kk}.");
            //Console.WriteLine($"Rendezés után {kkk}.");
            //Console.ReadKey();
            #endregion

            ///1. A tömb véletlen számmal való feltöltése. Semmi más.
            //2.Keresés.Ez egy új ciklus.
            //3.buborék rendezés.
            //4.Keresés.Megint egy új ciklus.

            #region nem jó
            //var seed = 25;
            //Random rnd = new Random(seed);
            //int[] block = new int[10];
            //int n = block.Length;

            //int k = 1;
            //int kk = 0;
            //int kkk = 0;

            ////Fel van töltve
            //for (int a = 0; a < n; a++)
            //{
            //    block[a] = rnd.Next(0, 1000);
            //}

            ////kell az új ciklus
            //for (int b = 0; b < n; b++)
            //{
            //    if (block[b] != 894)
            //    {
            //        k++;
            //    }
            //    if (block[b] == 894)
            //    {
            //        kk = k;
            //    }
            //}

            //////Buborék rendezés
            //for (int i = n - 1; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (block[j] > block[j + 1])
            //        {
            //            int b = block[j + 1];
            //            block[j + 1] = block[j];
            //            block[j] = b;
            //        }
            //    }
            //}

            //k = 0;
            //for (int c = 0; c < n; c++)
            //{
            //    if (block[c] != 894)
            //    {
            //        k++;
            //    }
            //    kkk = k;
            //}

            //Console.WriteLine($"Rendezés előtt {kk}.");
            //Console.WriteLine($"Rendezés után {kkk}.");
            //Console.ReadKey();
            #endregion

            //rendezés előtt és után is
            //Mondd meg, mi a legkissebb és a legnyagobb elem a tömbben

            var seed = 25;
            Random rnd = new Random(seed);
            int[] block = new int[10];
            int n = block.Length;
            int firstPosition = 0;
            int min, max;

            //Fel van töltve
            for (int a = 0; a < n; a++)
            {
                block[a] = rnd.Next(0, 1000);
            }

            //kell az új ciklus
            for (int b = 0; b < n; b++)
            {
                if (block[b] == 894)
                {
                    firstPosition = b;
                    break;
                }
            }

            max = block[0]; min = block[0];

            for (int d = 1; d < n; d++)
            {
                if (block[d] > max) max = block[d];

                if (block[d] < min) min = block[d];
                break;
            }
            Console.WriteLine($"Rendezés előtt a számok minimuma: {min}, maximuma: {max}");

            ////Buborék rendezés
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (block[j] > block[j + 1])
                    {
                        int b = block[j + 1];
                        block[j + 1] = block[j];
                        block[j] = b;
                    }
                }
            }

            firstPosition = 0;
            for (int c = 0; c < n; c++)
            {
                if (block[c] == 894)
                {
                    firstPosition = c;
                    break;
                }
            }

            max = block[0]; min = block[0];

            for (int d = 1; d < n; d++)
            {
                if (block[d] > max) max = block[d];

                if (block[d] < min) min = block[d];
                break;
            }
            Console.WriteLine($"Rendezés után a számok minimuma: {min}, maximuma: {max}");

            Console.WriteLine($"Rendezés előtt {firstPosition}.");
            Console.WriteLine($"Rendezés után {firstPosition}.");
            Console.ReadKey();


        }

    }
}
