using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_16_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  BREAKOUT ROOM 1
            //  Vytvoř třídu Obdelnik (tak, aby byla v samostatnem souboru Obdelnik.cs), která bude mít dva fieldy: Sirka a Vyska.
            //  Vytvoř konstruktor třídy Obdelnik s parametry sirka a vyska.
            //  Přidej do třídy ještě jeden typ konstruktoru pro speciální případ obdelníku(čtverec) s jedním parametrem, který bude volat první konstruktor.
            //  Obdelniku vytvorte funkci Vypis informace, ktery vypise vysku a sirku.
            //  Vytvoř několik instancí třídy Obdelnik (například 2) a vypiš jejich vlastnosti pomoci metody VypisParameteryObdelniku.

            Console.WriteLine("Lekce 06 BR01");
            Obdelnik o1 = new Obdelnik(2, 3);
            Obdelnik o2 = new Obdelnik(5);
            Console.WriteLine("první instance");
            o1.VypisInformace();
            Console.WriteLine("druhá instance");
            o2.VypisInformace();
            Console.ReadLine();
        }
    }
}
