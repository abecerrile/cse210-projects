using System;
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter your grade percentage: ");
        double gradePercentage = Convert.ToDouble(Console.ReadLine());

        char letter;
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

        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulations! You passed the course with a grade of {letter}.");
        }
        else
        {
            Console.WriteLine($"Keep working hard! Your grade is {letter}. You'll get there next time.");
        }

        Console.WriteLine($"Your letter grade is {letter}.");
    }
}
