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
            int[] block = new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            int n = block.Length;
            int i = 0;
            int alsoIndex;
          //  int felsoIndex;
            int stepCounter;

            for (i = 0; i < n; i++)
            {              
                Console.Write($"{block[i]}, ");
              
            }
            alsoIndex = block[0];
          //  felsoIndex = block[n];
            Console.Write($"{alsoIndex}, ");
         //   Console.Write($"{felsoIndex}, ");



            Console.ReadKey();
        }





    }
}
