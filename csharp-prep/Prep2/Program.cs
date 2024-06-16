using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percGrade = int.Parse(Console.ReadLine());
        string letterGrade, message;

        if (percGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (percGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (percGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (percGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "E";
        }

        //Setting the message for the user!
        if (percGrade >= 70)
        {
            message = "Congratulations!! You passed the class!!";
        }
        else
        {
            message = "Sorry, you failed the class!";
        }

        Console.Write($"Your grade is: {letterGrade}\n {message}");
    }
}