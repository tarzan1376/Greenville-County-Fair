using System;

class GreenvilleIdol
{
    const decimal ticketPrice = 25.00m;

    static void Main(string[] args)
    {
        while (true)
        {

            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CalculateRevenue();
                    break;
                case "2":
                    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                    return;
            }
        }
    }
    static void DisplayMenu()
    {
        Console.WriteLine("************************************" + "\n*  The stars shine in Greenville.  *" + "\n************************************");
        Console.WriteLine("\nPlease Enter the following number below from the following menu: ");
        Console.WriteLine("\n1. CALCULATE Greenville Revenue Year-Over-Year" + "\n2. Exit");
    }
    static void CalculateRevenue()
    {
        try
        {
            Console.Write("Enter the number of contestants this year: ");
            int contestantsThisYear = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of contestants last year: ");
            int contestantsLastYear = int.Parse(Console.ReadLine());

            decimal expectedRevenue = contestantsThisYear * ticketPrice;
            Console.WriteLine($"Revenue expected this year is ${expectedRevenue}");

            if (contestantsThisYear > contestantsLastYear)
            {
                Console.WriteLine("It is true that this year's competition is bigger than last year's.");
            }
            else
            {
                Console.WriteLine("This year's competition does not have more contestants than last year.");
            }
        
        } 
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
    
}