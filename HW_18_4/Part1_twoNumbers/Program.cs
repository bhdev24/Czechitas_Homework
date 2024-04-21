using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_twoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.

            //declare all variables required
            string userInput = "";
            int num_first = 0;
            int num_second = 0;
            int result = 0;
            bool isNumber = false;

            // this block asks for a user input until the user input is an integer, otherwise asks again
            do
            {
                Console.WriteLine("Input your first whole number: ");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out num_first))
                {
                    Console.WriteLine($"You've inputed number: {num_first}");
                    isNumber = true;
                }
                else
                    Console.WriteLine("That not a whole number. Try again.");

            } while (isNumber == false);
            isNumber = false; //reset the bool for the second number block

            // this block asks for a user input until the user input is an integer, otherwise asks again

            do
            {
                Console.WriteLine("Input your second whole number: ");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out num_second))
                {
                    Console.WriteLine($"You've inputed number: {num_second}");
                    isNumber = true;
                }
                else
                    Console.WriteLine("That not a whole number. Try again.");

            } while (isNumber == false);

            result = num_first - num_second; // final result

            Console.WriteLine($"The sum of {num_first} and {num_second} is {result}.");
            Console.ReadLine(); //to prevent from closing
            
        }
    }
}
