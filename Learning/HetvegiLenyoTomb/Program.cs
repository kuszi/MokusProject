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
            int alsoIndex;
            int felsoIndex;

            int stepCounter;

            for (i = 0; i < n; i++)
            {
                block[i] = i;
                Console.Write($"{block[i]}, ");
            }
           
            alsoIndex = block[0];
            felsoIndex = block[n - 1];
            Console.WriteLine($"\n A tömb első elem: {alsoIndex}.");
            Console.WriteLine($"A tömb utolsó elem: {felsoIndex}.");

            //vedd az alsoIndex és felsoIndex összegének a felét és lefelé kerekítsd.
            double osszeg = (alsoIndex + felsoIndex);
            double osszegfele = osszeg / 2;
            double kerekites = Math.Floor((double)osszegfele );
            
            Console.WriteLine($" Az alsoIndex és felsoIndex összegének a felét és lefelé kerekítsd.{kerekites}");
            int iKerekites = (int)kerekites;

            for (i = 0; i < n; i++)
            {                
                block[i] = i;
                if(block[i]==iKerekites)
                {
                    block[i] = iKerekites;
                    break;                    
                }
            }

            //        l. if 9 == 13
            //            - ha egyezik, akkor itt a keresés vége
            //            - ha kissebb, akkor az alsoIndex kapja meg ezt az értéket. alsoIndex = 9-- most ez a helyzet
            //-ha nagyobb, akkor a felsoIndex kapja meg ezt az értéket. felsoIndex = 9

            if (iKerekites == 13)
            {
                Console.WriteLine($"Meg van a 13.");
            }
            else if (felsoIndex < 13)
            {
                alsoIndex = block[i - 1];
                Console.WriteLine($"A tömb alsóindexe elem: {alsoIndex}.");
            }
            else
            {
                felsoIndex = block[i - 1];
                Console.WriteLine($"A tömb felsiindexe elem: {felsoIndex}.");
            }








            if (alsoIndex == felsoIndex && alsoIndex!=13)
            {                
                Console.WriteLine($"Vége: nincs találat.");
            }

            Console.ReadKey();
        }





    }
}
