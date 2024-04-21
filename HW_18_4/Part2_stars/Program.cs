using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.
            string userInput = "";
            int repeat = 0;
            bool isNumber = false;
            string stars = "";

            // this block asks for a user input until the user input is an integer, otherwise asks again
            do
            {
                Console.WriteLine("How many stars do you want?");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out repeat))
                {
                    Console.WriteLine($"You want {repeat} stars. Here they are:");
                    isNumber = true;
                }
                else
                    Console.WriteLine("That not a whole number. Try again.");

            } while (isNumber == false);

            // prints one star as many times as is repeat
            
            for (int i=0; i<repeat; i++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine("Or did you want them one next to each other?");
            
            // adds a start to an empty string as many times as is repeat
            for (int i = 0; i < repeat; i++)
            {
                stars += "*";
            }
            Console.WriteLine(stars);


            Console.ReadLine(); //just to prevent closing 

        }
    }
}
