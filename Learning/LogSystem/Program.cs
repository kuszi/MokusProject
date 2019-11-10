using LogSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem
{
    class Program
    {
        // Két nuget package kell: NLog és NLog.config
        // Amikor ezeket hozzáadod, akkor létrejön egy Nlog.Config file
        // azt nyisd meg, ott elég jó linkek vannak, hogy kell kitölteni.
        // itt most felülírtam, de lemásoltam az NLog-copy.Config-ba az eredetit

        static void Main(string[] args)
        {
            var logDemo = new LogDemo();

            // egyszerű logoloás
            // ez az első Target-et használja az NLog.config-ban
            // JSON formátumban menti az alábbi adatokat: time, level, message, exception
            // ez az NLog.config-ban van definiálva
            // logoláskor létrehozza a "Logs" könyvtárat -- szintén az NLog.configban van megadva
            // plusz rákészűl az archiválásra.
            logDemo.SimpleLog();

            logDemo.DynamicLog();

            Console.WriteLine("Finished");
            Console.ReadLine();
        
        }
    }
}
