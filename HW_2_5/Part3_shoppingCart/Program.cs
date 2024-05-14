using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_shoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).

            // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.

            // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.

            Dictionary<string, int> shoppingCart = new Dictionary<string, int>();
            shoppingCart.Add("bread", 45);
            shoppingCart.Add("milk", 20);
            shoppingCart.Add("eggs", 90);
            shoppingCart.Add("juice", 30);
            shoppingCart.Add("apples", 15);
            shoppingCart.Add("tomatoes", 25);

            foreach (KeyValuePair<string, int> item in shoppingCart)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("");
            bool isThere = shoppingCart.ContainsKey("bread");
            Console.WriteLine($"Is there a \"bread\" in the shopping cart? - {isThere}");

            if (isThere == true)
            {
                Console.WriteLine($"The cost of \"bread\" is: {shoppingCart["bread"]}");

            }
            else
            {
                Console.WriteLine("There is no item like this.");
            }
            Console.WriteLine("");
            isThere = shoppingCart.ContainsKey("ham");
            Console.WriteLine($"Is there a \"ham\" in the shopping cart? - {isThere}");
            if (isThere == true)
            {
                Console.WriteLine($"The cost of \"ham\" is: {shoppingCart["ham"]}");
            }
            else
            {
                Console.WriteLine("There is no item like this.");
            }
            Console.WriteLine("");
            Console.WriteLine("You now have 2 breads.");
            shoppingCart["bread"] += shoppingCart["bread"];

            foreach (KeyValuePair<string, int> item in shoppingCart)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.ReadLine();



        }
    }
}
