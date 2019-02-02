using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HArmadikHaziSzazig
{
    class Program
    {
        //        Generálj 100 darab véletlenszámot 0 és 100 között
        //https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number-in-c

        //Írd ki a képernyőre, hogy hány darab 50-nél kissebb, illetve 50-nél nagyobb volt.
        //Az 50 az az 50-nél nagyobb kategóriába megy

        //írd ki továbbá a legkisebb és a legnagyobb generált számot

        static void Main(string[] args)
        {
            List<int> lista = new List<int>(); //létrehozok egy listát, amibe majd a random számokat gyűjtöm
            Random rnd = new Random();//random számok generálása

            for (int i = 0; i < 100; i++)//itt fogom elérni hogy 100 számom legyen, addig növelem amíg el nem éri a százat
            {
                lista.Add(rnd.Next(0, 100));//közeben pedig meghatározom hogy ezek a számok 0 és 100 közöttiek legyenek
            }
           
            foreach (int i in lista)
            {
                Console.Write("{0}, ", i);//kiiratom az ossze olya i számot ami benn van a listában
                //int a = 0;
                //int b = 0;
                //if (i >= 50)
                //{
                //    a++;
                    
                //}
                //else
                //{
                //    b++;
                   
                //}
                //Console.WriteLine($"50 nél kisebb számok: {b}db ");
                //Console.WriteLine($"50 nél nagyobb számok: {a}db ");
            }
            Console.ReadKey();
        }
    }
}
