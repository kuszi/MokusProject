using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logika
{
    class Class1
    {
        public static int c;
        public void szamol()
        {
            //szamoljunk el egytol tizig,
            // irjuk ki az 5nél nagyobbakat

            for (int i = 0; i < 10; i++)
            {
                if (i > 5)
                {

                    Console.WriteLine(i);
                }

            }

        }

        public void szamol2()
        {
            for (int i = 0; i < 10; i++)
            {
                c++;
            }
        }
    }
}
