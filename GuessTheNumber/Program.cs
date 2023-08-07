using System.Security.Cryptography;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Guess the number from 1-100 (Random)
            // count number of tries of player
            // Ask the player if they want to play again
            bool playAgain = true;
            int guessNum;
            int numOfTry;
            Random rand = new Random();
            var randomNumber = rand.Next(1,100+1);

            while (playAgain)
            {

                numOfTry = 0;
                guessNum = 0;
                String play;
                Console.WriteLine("Guess the number between 1-100");
                
                    while (guessNum != randomNumber)
                    {
                        guessNum = Convert.ToInt32(Console.ReadLine());

                        if (guessNum > randomNumber)
                        {
                            Console.WriteLine($"{guessNum} is Too High");
                        }
                        else if (guessNum < randomNumber)
                        {
                            Console.WriteLine($"{guessNum} is Too Low");
                        }

                        else
                        {
                            Console.WriteLine("Correct! Congratulations!!! ");
                        }
                        numOfTry++;
                    }
              
                Console.WriteLine($"Number of tries: {numOfTry}");
                Console.WriteLine("Would you like to play again? (Y/N)");
                play = Console.ReadLine();
                play = play.ToUpper();
                if (play == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for Playing! ");
                    Console.ReadKey();
                }

            }
        }

    }
}