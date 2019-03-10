using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProba1
{
   public class ClassUnderTest
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Kivon(int a, int b)
        {
            return a - b;
        }
        public int Szor(int a, int b)
        {
            return a * b;
        }
        public int Oszt(int a, int b)
        {
            return a / b;
        }
    }
}
