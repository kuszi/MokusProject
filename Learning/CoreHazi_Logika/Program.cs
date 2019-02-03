using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreHazi_Logika
{
    class Program
    {
        static void Main(string[] args)
        {
            Szamolasok s = new Szamolasok();
            s.SzamoljTizig();
            s.CsakParosSzamok();
            s.EgytolSzazig();
            s.EgytolSzazigParatlan();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
