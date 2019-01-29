using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logika
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 b = new Class1();
            Class1 a = new Class1();
            a.szamol();
            a.szamol2();
            a.szamol2();
            Console.WriteLine(Class1.c);
            b.szamol2();
            Console.WriteLine(Class1.c);

            Console.WriteLine("nyomj meg egy gombot");
            Console.ReadKey();

        }
    }
}
