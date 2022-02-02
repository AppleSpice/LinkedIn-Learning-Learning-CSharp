using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            int guessNumber = 0;
            int guessCount = 0;
            string guess = null;
            bool continueGame = true;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            //the course uses a do while loop here but I dont see the purpose
            //since it is going to be true no matter what at this point so it 
            //going to run at least once no matter what
            //I can see if more things happen before hand where we would want 
            //that to happen it being useful but that would still depend on the 
            //case and i dont see the use here

            while(continueGame){
                //ask for guess
                Console.WriteLine("What is your guess?");
                guess = Console.ReadLine();

                if(guess == "-1"){
                    //where we want game to end
                    continueGame = false;
                }
                else if (Int32.TryParse(guess, out guessNumber)){
                    //where we want to check how close we were
                    guessCount++;

                    if(guessNumber == theNumber){
                        //they got the correct number
                        continueGame = false;

                        Console.WriteLine($"You got it in {guessCount} Guesses!!");

                    //the course used a ternary statment here which seems like a much better
                    //idea and removes a lot of code
                    //Console.WriteLine("{0} than that.", guessNumber < theNumber ? "higher" : "lower");

                    } else if(guessNumber > theNumber){
                        //the guess is too high
                        Console.WriteLine("Lower than that.");
                    } else{
                        //the guess is too low
                        Console.WriteLine("Higher than that.");
                    }
                }
                else{
                    //what happens if a number was not entered
                    Console.WriteLine("That doesn't look like a number. Try again!");
                }
            }
            

            // Keep track of the number of guesses and the current user guess

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            
        }
    }
}
