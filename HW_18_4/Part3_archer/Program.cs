using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part3_archer
{
    class Lucistnik
    {
        public int PocetSipu;

        public Lucistnik(int pocetsipu)
        {
            PocetSipu = pocetsipu;
        }

        public void Vystrel()
        {
            Console.WriteLine($"Pocet sipu v toulci: {PocetSipu}.");
             for (int i = 0; i <= PocetSipu; i++)
             {
                if (i<PocetSipu)
                {
                    Console.WriteLine("Zasah!");
                }
                else if (i==PocetSipu)
                {
                    Console.WriteLine("Nemam sipy.");
                }
             }

            Console.ReadLine();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Vytvořte třídu Lucistnik, ktera bude mit vlastnost PocetSipu a metodu Vystrel. PocetSipu muze byt nastaven treba na 10.
            Pokud bude mit dost sipu, napise metoda Vystrel na konzoli text: Vzdy se strefim primo do prostred!
            Metoda Vystrel uvnitr s kazdym vystrelem snizi pocet sipu.
            Pokud bude pocet 0, metoda Vystrel vypise "Nemam sipy".
            Napiste program, ktery vytvori lucistnika a vystreli vsechny sipy.
            */

            int toulec;
            string userInput = "";
            bool isNumber = false;
            do
            {
                Console.WriteLine("Kolik sipu ma lucistnik?");
                userInput = Console.ReadLine();
                isNumber = false;
                if (int.TryParse(userInput, out toulec))
                {
                    isNumber = true;
                }
                else
                    Console.WriteLine("To neni cele cislo. Zkus to znovu.");
            } while (isNumber == false);

            Lucistnik novyLucistnik = new Lucistnik(toulec);

            novyLucistnik.Vystrel();

            


        }
    }
}
