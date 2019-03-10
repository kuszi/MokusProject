using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THOR
{
    class Program
    {
        static void Main(string[] args)
        {

            Térkép, amely 40 széles és 18 magas.
A program elindítása után: 
fény koordinátái: lightX és lightY
Thor: initialTX és initialTY
Meg kell adnia azt az irányt, hogy Thor merre induljon el.

 string[] inputs = Console.ReadLine().Split(' '); -string tömb
 int lightX = int.Parse(inputs[0]); // X pozíció
            int lightY = int.Parse(inputs[1]); //Y pozíció
            int initialTX = int.Parse(inputs[2]); // Thor X pozíció 
            int initialTY = int.Parse(inputs[3]); // Thor Y pozíció

            while (true) -addig csinálaja amíg igaz
        {
                int remainingTurns = int.Parse(Console.ReadLine()); // maga a mozgás
                string s = ""; // s változó

                if (initialTY > lightY) // ha initialTY nagyobb mint light Y
                {
                    s = s + "N"; //akkor es értéke legyen egyenlő S+ N
                    initialTY -= 1; ; //majd initialTY értéke csökkenjen 1-el

                }

                if (initialTY < lightY) // ha initialTY kissebb mint lightY
                {
                    s = s + "S"; //s érteéke legyen egyenlő s+ S
                    initialTY += 1; // initialTY növelem 1el

                }


                if (lightX < initialTX) //ha lightX kisebb initialTX-el
                {
                    s = s + "W"; //s legyen egyenlő s+ W val
                    initialTX -= 1;//thor y koordinátáját csökkentem 1 el

                }

                if (lightX > initialTX) //ha pedig lightX nagyobb mint initial TX
                {
                    s = s + "E"; //s legyen egyenlő s+ E-vel
                    initialTX += 1;//thor x koordinátákát növelem 1-el

                }

                Console.WriteLine(s);//végül kiiratom S-t


            }
        }
}
