using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");
        string inputText = Console.ReadLine();
        Console.WriteLine("Enter a letter:");
        char letter = Convert.ToChar(Console.ReadLine());

        int countLetter = 0;

        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i] == letter)
            {
                countLetter++;
            }
        }

        Console.WriteLine($"Letter {letter} appears {countLetter} times in {inputText}");
    }
}
