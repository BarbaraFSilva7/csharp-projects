namespace Customer_Satisfaction;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===============================");
        Console.WriteLine("     CUSTOMER SATISFACTION     ");
        Console.WriteLine("===============================");

        Console.WriteLine("\nOn a scale of 1 to 5, how would you rate our service? ");
        int rate = Convert.ToInt32(Console.ReadLine());

        switch (rate)
        {
            case 1:
                Console.WriteLine("\n1 - Terrible!");
                Console.WriteLine("Thanks for your feedback! We are sorry for the inconvenience.");
                break;

            case 2:
                Console.WriteLine("\n2 - Bad!");
                Console.WriteLine("Thanks for your feedback! We are sorry for the inconvenience.");
                break;

            case 3:
                Console.WriteLine("\n3 - Average! Thanks for your feedback!");
                break;

            case 4:
                Console.WriteLine("\n4 - Good! Thanks for your feedback!");
                break;

            case 5:
                Console.WriteLine("\nExcellent! Thanks for your feedback!");
                break;


            default:
                Console.WriteLine("\n[Invalid option! Please enter a number from 1 to 5]");
                break;
                
        }
    }
}
