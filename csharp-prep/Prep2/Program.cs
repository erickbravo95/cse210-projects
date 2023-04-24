using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string grade = Console.ReadLine();
        int gradeReal = int.Parse(grade);
        string letter = "";
        if (gradeReal >= 90)
        {
            letter = "A";
        }
        else if (gradeReal >= 80)
        {
            letter = "B";
        }
        else if (gradeReal >= 70)
        {
            letter = "C";
        }
        else if (gradeReal >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");

        if (gradeReal >= 70)
        {
            Console.WriteLine("Congratulations you pass!");
        }
        else
        {
            Console.WriteLine("Good luck next time");
        }
    }
}