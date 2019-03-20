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
            int[] inputs = { 1, 6, 2, 3, -5, 4, -6, -2, -1, -4, 0 };//Console.ReadLine().Split(' ');
            int aMAxValue = 6;


            for (int i = 0; i < inputs.Length; i++)
            {
                if (aMAxValue > Math.Abs(inputs[i]))
                {
                    aMAxValue = Math.Abs(inputs[i]);
                }
                else if (aMAxValue == Math.Abs(inputs[i]) && inputs[i] > aMAxValue)
                {
                    aMAxValue = inputs[i];
                }
                else if (i == 0)
                {
                    aMAxValue = inputs[i];
                }
                //int t = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("{0}", aMAxValue);


            Console.ReadKey();
            #region jatekban ig
            //int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
            //string[] inputs = Console.ReadLine().Split(' ');
            //int temperatureMax = 5526;

            //if (n > 0)
            //{

            //    for (int i = 0; i < n; i++)
            //    {
            //        int t = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526

            //        if (Math.Abs(t) < Math.Abs(temperatureMax))
            //        {
            //            temperatureMax = t;
            //        }
            //        else if (Math.Abs(t) == Math.Abs(temperatureMax) && t >= temperatureMax)
            //        {
            //            temperatureMax = t;
            //        }
            //        // Write an action using Console.WriteLine()
            //        // To debug: Console.Error.WriteLine("Debug messages...");        

            //    }

            //}
            //else
            //{
            //    temperatureMax = 0;
            //}




            //Console.WriteLine("{0}", temperatureMax);

            #endregion

        }
    }

}