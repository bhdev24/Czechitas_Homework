using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4_guessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Napište program, který umožní hádat číslo. Zeptá se, jaké číslo si myslím. Podle toho, jaké číslo se zadá, napíše, jestli je číslo větší nebo menší a umožní hádat tak dlouho, dokud se uživatel netrefí:
            Např.
            Hádej číslo: 10
            Číslo je menší, hádej znovu: 5
            Číslo je větší, hádej znovu: 7
            To je správně!
            */


            
            Console.WriteLine("Let's play a guessing game. You are to guess a number between 1 and 20.");
            // hadane cislo se generuje jako nahodne v danem rozmezi 1 az 20
            Random rnd = new Random();
            int num = rnd.Next(1, 21);
            bool gameOver = false;
            int guess;
            //zazadat o user input a overit, jestli je integer
            string userInput = "";
            bool isNumber = false;
            // blok hadani
            do
            {
                do
                {
                    Console.WriteLine("What is your guess?");
                    userInput = Console.ReadLine();
                    isNumber = false;
                    if (int.TryParse(userInput, out guess))
                    {
                        isNumber = true;
                    }
                    else
                        Console.WriteLine("That not a whole number. Try again.");
                } while (isNumber == false);

                if (guess == num)
                {
                    gameOver = true;
                }
                else if (guess < num)
                {
                    Console.WriteLine("Not correct. Your guess is smaller than the number.");
                }
                else
                {
                    Console.WriteLine("Not correct. Your guess is bigger than the number.");
                }
            } while (gameOver == false);
            
            //potvrzeni a ukonceni
            Console.WriteLine($"You are correct! It was {num}.");
            Console.ReadLine();



        }
    }
}
