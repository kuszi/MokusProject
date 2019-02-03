using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buborek
{
    class Program
    {
        //        És akkor a következő feladat
        //Készíts egy 10 elemű tömböt, töltsd fel véletlen számokkal 0-1000.

        //Kis kitérő
        //Most válassz magadnak egy életre szóló számot.Amit könnyen megjegyzel.pl:25 :)
        //és amikor a véletlenszámot példányosítod akkor ezt add meg paraméterként
        //var rnd = new Random(25);
        //        Ezt a 25-öt hívják seed-nek
        //        Azért jó, mert a továbbiakban generált véletlenszámok mindig ugyanazok lesznek.
        //        Tehát nagyon jó arra, hogy meg tudd ismételni a véletlent.


        //        naszóval, most hogy a 10 elemű tömböd megvan rendezd a legkissebbtől a legnagyobbig buborék rendezéssel.
        //itt találsz róla leírást: https://hu.wikipedia.org/wiki/Bubor%C3%A9krendez%C3%A9s

        static void Main(string[] args)
        {
            Random rnd = new Random();//random
            int[] block = new int[10];//tomb létrehozás és meghatározom hogy 10 elem legyen
            int n = block.Length;//n = a tömb hosszával, azaz 10 elemmel

            for (int a = 0; a < n; a++)//feltöltöm a tömb elmeit random számokkal
            {
                block[a] = rnd.Next(0, 1000);
                // Console.Write("{0} ", block[a]); //Kiíratás rendezés előtt
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
            //Console.WriteLine();

            //Kiíratás rendezés után
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0} ", block[c]);
            }

            Console.ReadKey();
        }
    }
}
