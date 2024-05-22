using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_16_5
{
    public class Obdelnik
    {
        private int vyska;
        public int Vyska
        {
            get
            {
                return vyska;
            }
            set
            {
                vyska = value;
            }
        }

        private int sirka;
        public int Sirka
        {
            get
            {
                return sirka;
            }
            set
            {
                sirka = value;
            }
        }

        public Obdelnik(int sirka, int vyska)
        {
            if (sirka * vyska == 0)
            {
                Console.WriteLine("Nelze vytvorit obdelnik s obsahem nula, nastavuji sirku a vysku na 1.");
                this.Sirka = 1;
                this.Vyska = 1;
            }
            else
            {
                Console.WriteLine($"Tvorim obdelnik se stranami {sirka} a {vyska}.");
                this.Sirka = sirka;
                this.Vyska = vyska;
            }
        }
        public Obdelnik(int strana)
        {
            Console.WriteLine($"Tvorim ctverec se stranou {strana}.");
            this.Sirka = strana;
            this.Vyska = strana;
        }

        public double Obvod
        {
            get
            {
                return 2 * (Sirka + Vyska);
            }
        }

        public double Obsah
        {
            get
            {
                return (Sirka * Vyska);
            }
        }


        public void VypisInformace()
        {
            Console.WriteLine("Sirka: {0}", Sirka);
            Console.WriteLine("Vyska: {0}", Vyska);
            Console.WriteLine($"Obvod: {Obvod}");
            Console.WriteLine($"Obsah: {Obsah}");
        }

        public void Zvetsi()
        {
            Sirka *= 2;
            Vyska *= 2;
            VypisInformace();
        }
    }
}
