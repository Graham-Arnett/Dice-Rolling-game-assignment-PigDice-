using System.Runtime.CompilerServices;

namespace PigDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to PigDice!"); //this is our title
            //in the instructions it asks for the number of times to play
            //this is important, because it runs for a specific number of times, we can use a for loop
            //however, the instructions also prompt if you want to play again only after it finishes running the above number of times
            //from this I think the for loop is nested inside of a do/while loop
            Random random = new Random(); //I thought you couldn't do randoms in static though? 
            int gameNum = 0;
            int highScore = 0; //I get it, these would be initialized at zero because they'll INCREMENT every game
            //I think I need to define the string for y or Y up here
              string play; //I had defined this as Y initially, think that was wrong but we'll see I'm still learning
            do
            {
                Console.Write("How many times would you like to roll the dice?: ");//prompting input
                int playAmount = int.Parse(Console.ReadLine()); //had to check the syntax against a different project where I used a for loop, looks good
                int totalScore = 0; //this represents the total added score
                if (playAmount <= 0) //for data validation honestly forgot this step
                {
                    Console.WriteLine("That was not a valid input, please enter an integer.");
                }
                else //upside, this does check if an invalid number is entered, the downside is it only checks for numbers, and it still increments, which means I might have a curly brace in the wrong spot
                {
                   
                    
                    for (int i = 1; i <= playAmount; i++) //if I understand right, this would the amount of times specified
                    {
                        //we will be doing the actual dice rolling inside of here
                        int roll = random.Next(1, 7);
                        totalScore += roll;
                    }
                }
                gameNum++;
                if (totalScore > highScore)
                    highScore = totalScore;
                //just occurred to me that most of the output should be down here in the do not the for
                Console.WriteLine("Here we go!"); //not really important just flavor
                Console.WriteLine($"We played {gameNum} games");
                Console.WriteLine($"The highest score was {highScore}");
                Console.Write("\nWould you like to play again? (y/n): "); //this should be for prompting the user to play again
                play = Console.ReadLine().Trim().ToLower();
            
            } while (play == "y"); //do while is essential so it runs once first, then breaks if anything BUT Y or y is entered

            Console.WriteLine("Thanks for playing!"); //the point here is to show where it ends
        }

    }
}
