using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBeolv
{
    class Program
    {
        static void Main(string[] args)
        {
            //   csatoltam egy csv file-t, ami 3 oszlopot tartalmaz: a,b, osszeg
            //   két szám és az összegük.

            //Console alkalamzás legyen.
            //Olvasd be a file-t
            //menj végig sorról sorra és ird ki szépen olvashatóan a sor tartlmát. pl: 4 + 5 = 9
            //látni fogod, hogy pár helyen rossz az összeg.direkt van így
            //azt is szeretném, hogy a kiírás tartalmazza azt is, hogy az összeg helyes vagy helytelen

            //azaz a végső sor valahogy így fog kinézni
            //4 + 5 = 9 helyes
            //2 + 3 = 7 helytelen

            StreamReader sr = new StreamReader("../../feladat.csv");
            string data = sr.ReadLine();
            while (data != null)
            {
                Console.WriteLine(data);
               
                var values = data.Split(',');
                int aszam, bszam, osszeguk;
                var a = int.TryParse(values[0], out aszam);
                var b = int.TryParse(values[1], out bszam);
                var osszeg = int.TryParse(values[2], out osszeguk);
                data = sr.ReadLine();





            }
            Console.ReadKey();
        }

    }
}


