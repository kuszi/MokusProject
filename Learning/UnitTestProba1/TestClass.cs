using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProba1
{
  public  class TestClass
    {
        public void DoTestAdd()
        {
            //OK: 3-nak kell lenni a 1+2

           var classUnderTest = new ClassUnderTest();
            var result = classUnderTest.Add(1, 2);

            if (result == 3)
                Console.WriteLine("ok");
            else
                Console.WriteLine("nem ok");
        }

        public void DoTestKivon()
        {
            // NEM OK: -1-nek kell lennie 3-4

            var classUnderTest = new ClassUnderTest();
            var result = classUnderTest.Kivon(3, 4);

            if (result == 1)
                Console.WriteLine("ok");
            else
                Console.WriteLine("nem ok");
        }

        public void DoTestSzor()
        {
            //NEM OK: 30-nak kell lennia 5*6

            var classUnderTest = new ClassUnderTest();
            var result = classUnderTest.Szor(5, 6);

            if (result == 2)
                Console.WriteLine("ok");
            else
                Console.WriteLine("nem ok");
        }

        public void DoTestOszt()
        {
            //OK: 6/2=3

            var classUnderTest = new ClassUnderTest();
            var result = classUnderTest.Oszt(6, 2);

            if (result == 3)
                Console.WriteLine("ok");
            else
                Console.WriteLine("nem ok");
        }

    }
}
