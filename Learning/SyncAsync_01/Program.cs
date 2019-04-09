using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncAsync_01
{
    class Program
    {
        // Ebben a kis programban a fő program szálon "*" karaketereket írunk ki
        // Egy párhuzamosan futo Task-ban pedig "-" karaktereket

        // A két kód egymás mellett párhuzamosan fut. 
        // A windows gondoskodik arról, hogy mindkét programszál (task) kapjon egy kis időszeletet a futáshoz

        // ha többször egymás után futtatod, akkor teljesen más kimenetet kaphasz
        // Ez a Windows szálütemezője miatt van. Hol az egyik szál kap egy kis időt, hol a maásik. A kis időt viszont mindig más

        // HÁZI FELADAT
        // 1. megérteni, ha kérdés van, akkor kérdezni
        // 2. Vegyél fel mégy egy taskot, ami "T" karaktereket ír ki
        // 3. vegyél fel pluszmég egy taskot, ami "+" jeleket ír ki
        // 4. A főprogram a "*" karakterek kiírása után írjon ki 100 db "#" jelet

        // Ha a 4. ponttal is kész vagy, láthatod, a "#" karakterek mindig az összes "*" kirakása után van.
        // Ez logikus, hiszen ez a szinkron futás (amikor az egyik művelet a másik után hajtódik végre)
        // Ezzel szemben a "-", "T" és "+" jelek bárhol megjelenhetnek, mert külön szálon (külön taskban) futnak. Ez az asyncron futás

        static object lakatKulcs = new object();//referencia típus kell

        static void Negativ()
        {

            for (int i = 0; i < 100; i++)
            {
                Console.Write("-");
                Thread.Sleep(1);
            }

        }

        static void Tfgv()
        {
            for (int i = 0; 1 < 100; i++)
            {
                Console.Write("T");
                Thread.Sleep(2);
            }
        }


        static void PLuszfgv()
        {
            for (int i = 0; 1 < 100; i++)
            {
                Console.Write("+");
                Thread.Sleep(2);
            }
        }

        static void Main(string[] args)
        {

            //Task task = Task.Factory.StartNew(() =>
            //{  for (int i = 0; i < 100; i++)
            //    {
            //        Console.Write("-");
            //        Thread.Sleep(1);
            //    }
            //});        


            //Task taskT = Task.Factory.StartNew(() =>
            //{
            //    for (int i = 0; 1 < 100; i++)
            //    {
            //        Console.Write("T");
            //        Thread.Sleep(2);
            //    }
            //});

            //Task taskPLusz = Task.Factory.StartNew(() =>
            //{
            //    for (int i = 0; 1 < 100; i++)
            //    {
            //        Console.Write("+");
            //        Thread.Sleep(2);
            //    }
            //});




            int length = 3;
            Task[] tasks = new Task[length];
            for (int i = 0; i < length; i++)
            {
                if (i == 1)
                {
                    tasks[i] = new Task(() => Negativ());
                }
                else if (i == 2)
                {
                    tasks[i] = new Task(() => Tfgv());
                }
                else if (i == 3)
                {
                    tasks[i] = new Task(() => PLuszfgv());
                }
            }
            for (int i = 0; i < length; i++)
            {
                tasks[i].Start();
            }



            ///Fő szál
            for (int i = 0; i < 100; i++)
            {
                //if (i == 100 || i > 100)
                //{
                //    for (int j = 0; j < 100; j++)
                //    {
                //        Console.Write("#");
                //        Thread.Sleep(1);
                //    }
                //}

                //else
                //{
                Console.Write("*");
                Thread.Sleep(1);
                //}
            }


            Task.WaitAll(tasks);
            // Console.WriteLine();
            // Console.ReadLine();


            Console.WriteLine("Done. Press Enter");
            Console.ReadLine();
        }
    }
}
