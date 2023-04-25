using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> lista = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int numberReal = -1;
        do
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            numberReal = int.Parse(number);
            if (numberReal != 0)
            {
               lista.Add(numberReal); 
            }
        } while(!(numberReal == 0));

        int sum = 0;
        foreach (int i in lista)
        {   
            sum = sum + i;
        }

        Console.WriteLine($"The sum is: {sum}");
        double ave = lista.Average();
        Console.WriteLine($"The average is: {ave}");
        int large = lista.Max();
        Console.WriteLine($"The largest number is: {large}");
    }
}