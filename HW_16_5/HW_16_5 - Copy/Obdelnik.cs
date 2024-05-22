using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_16_5
{
    public class Obdelnik
    {
        public int Sirka;
        public int Vyska;
        public Obdelnik(int sirka, int vyska)
        {
            this.Sirka = sirka;
            this.Vyska = vyska;
        }
        public Obdelnik(int strana) : this(strana, strana)
        {
        }
        public void VypisInformace()
        {
            Console.WriteLine("Sirka: {0}", Sirka);
            Console.WriteLine("Vyska: {0}", Vyska);
        }
    }
}
