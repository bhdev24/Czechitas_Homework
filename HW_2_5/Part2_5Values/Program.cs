using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_5Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.

            // 4. Smaž z tohoto listu libovolnou hodnotu.

            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains

            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").

            List<string> colours = new List<string>() { "white", "black", "red", "blue", "yellow" };
            colours.Remove("yellow");
            bool isThere = colours.Contains("brown");
            Console.WriteLine($"Does the list contain the colour \"brown\"? - {isThere}");
            int amount = colours.Count;
            string listOf = "";
            for (int i = 0; i < colours.Count; i++)
            {
                listOf = listOf + colours[i] + " ";
            }
            Console.WriteLine($"There are {amount} values in the colours list. This is the list of the values in the list: {listOf}");
            Console.ReadLine();

        }
    }
}
