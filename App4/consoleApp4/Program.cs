using System;

class Program
{
    static void Main()
    {
        int number;

        do
        {
            Console.Write("Enter a positive even number: ");
            string input = Console.ReadLine();
	    number = Convert.ToInt32(input);

            if (number > 0 && number % 2 == 0)
            {
                int square = number * number;
                Console.WriteLine($"The square of {number} is: {square}");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive even number.");
            }
        } while (true);
    }
}
