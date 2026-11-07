namespace LotteryGame;

public class Program
{
    public static void Main()
    {
        Random random = new Random();

        Console.WriteLine("========================================================");
        Console.WriteLine("       WELCOME TO THE MILLION-DOLLAR LOTTERY   ");
        Console.WriteLine("========================================================");
        Console.WriteLine("Rules: Choose 3 numbers from 1 to 20");
        Console.WriteLine("Match all 3 numbers (in any order) to win the jackpot! ");
        Console.WriteLine("Type 0 anytime to exit the game");

        while (true)
        {
            // Computer generates 3 random numbers between 1 and 20
            int num1 = random.Next(1,21);
            int num2 = random.Next(1,21);
            int num3 = random.Next(1, 21);

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Enter your first number: ");
            int firstguess = Convert.ToInt32(Console.ReadLine());
            if (firstguess == 0) break;

            Console.WriteLine("Enter your second number: ");
            int secondguess = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third number: ");
            int thirdguess = Convert.ToInt32(Console.ReadLine());

            //Show the results
            Console.WriteLine("\n--- Result ---");
            Console.WriteLine($"Winning numbers: {num1}, {num2}, {num3}");
            Console.WriteLine($"Your guesses: {firstguess}, {secondguess}, {thirdguess}");

            // Count total correct guesses
            int matches = 0;

            //Check first guess 
            if (firstguess == num1 || firstguess == num2 || firstguess == num3) matches++;

            //Check second guess
            if (secondguess == num1 || secondguess == num2 || secondguess == num3) matches++;

            //Check third guess
            if (thirdguess == num1 || thirdguess == num2 || thirdguess == num3) matches++;

            //Final message evaluation
            if (matches == 3)
            {
                Console.WriteLine("\n🎉 JACKPOT!!! YOU WON 1 MILLION DOLLARS! 🎉");
            }
            else
            {
                Console.WriteLine($"\nYou got {matches} correct number(s). Play again!");
            }
        }
        Console.WriteLine("\nThanks for playing! Game over");
    }

}
