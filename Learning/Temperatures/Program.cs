using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region feledat
            //int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
            //string[] inputs = Console.ReadLine().Split(' ');
            //for (int i = 0; i < n; i++)
            //{
            //    int t = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526
            //}

            //// Write an action using Console.WriteLine()
            //// To debug: Console.Error.WriteLine("Debug messages...");

            //Console.WriteLine("result");
            #endregion

   
            //int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
            int[] inputs = {1, 6, 2, 3, -5, 4,-6,-2,-1,-4 ,0};//Console.ReadLine().Split(' ');

            // *** Na ennek kéne int.MaxValue -nak lennie
            int aMAxValue =  6;
            for (int i = 0; i < inputs.Length; i++)
            {
                
                if (aMAxValue > Math.Abs(inputs[i]))
                {
                    aMAxValue = Math.Abs(inputs[i]);
                }
                // *** Ez a feltétel sose tud teljesülni.
                // *** gondolj bele, a aMAxValue a legnagyobbat tartalmazza, azaz Mindig Pozitiv. Ha már egyszer egyenlő, akkor utána már az inputs[i] nem tud nagyobb lenni
                // *** De azt nagyon jól látod, hogy egy ehhez hasonló if ide KELLENI FOG :) 
                else if (aMAxValue == Math.Abs(inputs[i]) && inputs[i] > aMAxValue)  
                {
                    aMAxValue = inputs[i];
                }
                // *** felesleges. a legelső if megoldja ezt a problémát
                else if (i == 0)
                {
                    aMAxValue = inputs[i];
                }
                //int t = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526
            }

            // *** KISS segítség :)
            // *** az már nagyon jó, hogy az aMAxValue-ban tárolod a távolságot
            // *** de mivel ez eredetileg lehetett egy negatív szám is, lehet hogy azt is tárolni kéne :)

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("{0}", aMAxValue);


            Console.ReadKey();


           



        }
    }

}

