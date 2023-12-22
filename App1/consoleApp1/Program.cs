using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("You will enter three numbers.");

        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double largestNumber = num1;

        if (num2 > largestNumber) largestNumber = num2;
        if (num3 > largestNumber) largestNumber = num3;

        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}
