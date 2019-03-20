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
          
            int[] inputs = new int[11] { 1, 6, 2, 3, -5, 4, -6, -2, -1, -4, 0 };
            int aMAxValue = 6;

            if (inputs.Length > 0)
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    if (Math.Abs(aMAxValue) > Math.Abs(inputs[i]))
                    {
                        aMAxValue = i;
                    }
                    else if (Math.Abs(aMAxValue) == Math.Abs(inputs[i]) && i >= aMAxValue)
                    {
                        aMAxValue = i;
                    }
                }
            }
            else
            {
                aMAxValue = 0;
            }

            Console.WriteLine("{0}", aMAxValue);


            Console.ReadKey();
            Console.ReadLine();

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