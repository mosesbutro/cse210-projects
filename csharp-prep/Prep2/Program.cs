using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your score in percentage: ");
        string userScore = Console.ReadLine();
        int gradePercentage = int.Parse(userScore);

        // Declare variables to store the letter grade and sign 
        char letter;
        char sign = ' ';

        // Determine the letter grade based on the percentage
        if (gradePercentage >= 90)
        {
            letter = 'A';
        }
        else if (gradePercentage >= 80)
        {
            letter = 'B';
        }
        else if (gradePercentage >= 70)
        {
            letter = 'C';
        }
        else if (gradePercentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }    
        

        // Determine the sign based on the last digit of the percentage
        int lastDigit = gradePercentage % 10;
        if (letter != 'F') // Exclude F grade
        {
            if (lastDigit >= 7)
            {
                sign = '+';
            }
            else if (lastDigit < 3)
            {
                sign = '-';
            }
        }

        // Handle exceptional cases
        if (letter == 'A' && sign == '+')
        {
            sign = ' ';
        }
        else if (letter == 'F')
        {
            sign = ' ';
        }

        // Print the letter grade and sign
        Console.WriteLine("Your letter grade is: " + letter + sign);

        // Check if the student passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You did not pass the course. Keep working hard for next time.");
        }
    }
}