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

            // BREAKOUT ROOM 2
            // Vyuzij tridu Obdelnik z prvniho BR.
            //  Prepis fieldy Sirka a Vyska na properties.
            //  Nastavte properties tak, aby je nebylo mozne zmenit po vytvoreni instance.  
            //  Vytvorte property Obsah, ktera umozni ziskat obsah obdelniku.
            //  Vytvorte property Obvod, ktera umozni ziskat obvod obdelniku.
            //  Vytvorte funkci Zvetsi, ktera zvetsi obdelnik o sirku a vysku.
            //  Zajistete, aby nebylo mozne vytvorit obdelnik o obsahu 0 (vypiste hlasku a nastavte hodnotu na 1).
            //  Napiste program, ktery vytvori obdelnik, vypise jeho velikosti, obsah a obvod.

            Console.WriteLine("Lekce 06 BR01");
            Obdelnik o1 = new Obdelnik(2, 3);
            Obdelnik o2 = new Obdelnik(5);
            Obdelnik o3 = new Obdelnik(0,5);
            Console.WriteLine("první instance");
            o1.VypisInformace();
            Console.WriteLine("aplikuji funkci Zvetsi");
            o1.Zvetsi();
            Console.WriteLine("druhá instance");
            o2.VypisInformace();
            Console.WriteLine("aplikuji funkci Zvetsi");
            o2.Zvetsi();
            Console.WriteLine("treti instance");
            o3.VypisInformace();
            Console.WriteLine("aplikuji funkci Zvetsi");
            o3.Zvetsi();
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
