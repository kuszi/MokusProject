using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABValtozo
{
//kövi feladat(kivételesen "a" és "b" ávltozó lesz :) :)
//Szóval vegyél fel két változót A és B
//mindkettőbe tegyél egy random értéket 0-1000 között
//Ha A értéke nagyobb mint B értéke akkor A-ba menjen B és B-be menjen A(magyarul felcseréled őket)

//és írd is ki hogy mi volt az eredeti értékük, illetve ha csere volt akkor azt is, hogy csere történt és mi az új érték
//ha nem kell cserélni, akkor azt is írd ki

    class Program
    {
        static void Main(string[] args)
        {            
            Random rnd = new Random();
            int A = rnd.Next(0, 1000);
            int B = rnd.Next(0, 1000);

            Console.WriteLine($"A értéke: {A}");
            Console.WriteLine($"B értéke: {B}");

            if (A > B)
            {
                Console.WriteLine($"A éréke nagyobb mint B, ezért felcseréljünk őket.");
                A = B;
                Console.WriteLine($"A új értéke: {A}");
            }
            else
            {
                Console.WriteLine($"B éréke nagyobb mint A, ezért nincs szükség cserére.");                
            }
           
            Console.ReadKey();
        }
    }
}
