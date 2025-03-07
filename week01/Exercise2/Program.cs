using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?. ");
        int gradeValue = int.Parse(Console.ReadLine());

        string gradeLetter = " ";
        string letterSign = " ";

        if (gradeValue >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeValue >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeValue >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeValue >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }   

        // Determining the Sign
        int lastDigit = gradeValue % 10;
        if (gradeLetter != "A" && gradeLetter != "F")
        {
            if (lastDigit >= 7)
            {
                letterSign = "+";
            }
            else if (lastDigit < 3)
            {
                letterSign = "-";
            }
        }
        else if (gradeLetter == "A" && lastDigit < 3)
        {
            letterSign = "-";
        }

        // Printing the final Grade
        Console.WriteLine($"Your grade is: {gradeLetter} {letterSign}");

        if (gradeValue >= 70)
        {
            Console.WriteLine("Hey!, You Passed Congratulations");
        }
        else
        {
            Console.WriteLine("Hey! Better Luck Next Time");
        }
    }
}
