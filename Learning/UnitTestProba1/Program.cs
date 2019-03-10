using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProba1
{
    class Program
    {
        static void Main(string[] args)
        {
           // ClassUnderTest newclass = new ClassUnderTest();
            //newclass.Add(1, 2);
            //newclass.Kivon(2, 1);
            //newclass.Szor(1, 2);
            //newclass.Oszt(2, 1);
            var newTestClass = new TestClass();
            newTestClass.DoTestAdd();
            newTestClass.DoTestKivon();
            newTestClass.DoTestSzor();
            newTestClass.DoTestOszt();

            Console.ReadKey();
        }
    }
}
