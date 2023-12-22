using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        Console.WriteLine("Enter a count:");
        int count = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[count];
        string output = "";

        Console.WriteLine($"Enter {count} numbers:");

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Number {i + 1}: ");
	        int number = Convert.ToInt32(Console.ReadLine());
            numbers[i] = number;

            if (i != 0 && number >= 0)
                output += "+";
            output += number;
        }

        for (int i = 0; i < count; i++)
        {
            sum += numbers[i];
        }
        output += $" = {sum}";

        Console.WriteLine(output);
    }
}
