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

        #region próbálkozás
        //static void RunIntNDoubleRandoms(Random randObj)
        //{
        //    // Generate the first six random integers.
        //    for (int j = 0; j < 6; j++)
        //        Console.Write(" {0,10} ", randObj.Next());
        //    Console.WriteLine();
        //}

        //static void FixedSeedRandoms(int seed)
        //{
        //    Console.WriteLine(
        //        "\nRandom numbers from a Random object with " +
        //        "seed = {0}:", seed);
        //    Random fixRand = new Random(seed);

        //    RunIntNDoubleRandoms(fixRand);
        //}
        
        #endregion

        static void Main(string[] args)
        {
           
            var seed = 25;//nekem ez nem működik.....
//var random = new Random(seed);
       //     var rnd = new Random(seed);
            Random rnd = new Random(seed);//seed /ugyan azon random értékek
            int[] block = new int[10];
            int n = block.Length;
            int k = 0;//ő lesz a kulcs elem, ha nem egyenlő a block[a] 894-el akkor k-t növelem


            for (int a = 0; a < n; a++)
            {
                block[a] = rnd.Next(0, 1000);            
                                
                if (block[a] != 894)
                {
                    k++;
                }
                Console.Write("894 szám a {0}. helyen áll. ", k); //ezen a helyen áll a 894
            }
                      

            ////Buborék rendezés
            for (int i = n - 1; i > 0; i--) //veszem az utolsó előtti elemet, majd megvizsgálom hogy az nagyobb e mint 0, majd  egyel előtte lévő elemet nézem
            {
                for (int j = 0; j < i; j++)//új változót vezetek be ami t, megvizsgálok hogy kisebb e mint az i elem, majd növelem eggyel
                {
                    if (block[j] > block[j + 1])//ha a több j-eig elem nagyobb mint a több j+1 eleme akkor
                    {
                        int b = block[j + 1];//be kell vezetni egy új változót hogy elvégezhető legyen a csere, jelen esetben b egyenlő lesz a tömb j+1 elemével mert az nagyobb mint j
                        block[j + 1] = block[j];
                        block[j] = b;
                    }
                }
            }

            //Kiíratás rendezés után
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0} ", block[c]);
                for (int o = 0; o < n; o++)
                {
                    if (block[o] != 894)
                    {
                        k++;
                    }
                    Console.Write("894 szám a {0}. helyen áll a rendezés után. ", k); //ezen a helyen áll a 894
                }
            }

            Console.ReadKey();
        }


    }
}
}
