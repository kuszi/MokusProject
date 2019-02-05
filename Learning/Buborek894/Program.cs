using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buborek894
{
    class Program
    {
        //   new random(25);				 
        //10 elemű tömb = random 0,1000
        //   lesz 894 érték seed értelme, ugyan azok a random számok       
        //    rendezés előtt meg kell keresni hogy a 894 hol van a tömbben, milyen index, majd rendezem és megmondom hol van

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

            var seed = 25;
            Random rnd = new Random(seed);
            int[] block = new int[10];
            int n = block.Length;

            int k = 0;
            int kk = 0;
            int kkk = 0;


            //Feltöltöm a tömböt random számokkal
            for (int a = 0; a < n; a++)
            {
                block[a] = rnd.Next(0, 1000);
                Console.Write("{0} ", block[a]);
                if (block[a] != 894)
                {
                    k++;
                }
                else
                {
                    kk = k;
                }

            }

            Console.WriteLine();
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

            for (int c = 0; c < n; c++)
            {
                Console.Write("{0} ", block[c]);
                if (block[c] != 894)
                {
                    k++;
                }
                else
                {
                    kkk = k;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Rendezés előtt {kk}.");
            Console.WriteLine($"Rendezés után {kkk}.");
            Console.ReadKey();

        }

    }
}
