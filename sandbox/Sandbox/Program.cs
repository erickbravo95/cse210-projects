using System;

class Program
{
    static void Main(string[] args)
    {
        /*for (int i = 4; i > 0; i--){
            Console.Write($"breathe in...{i}");
           // Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b \b\b\b\b\b\b\b\b");
        }
        Console.WriteLine();
        for (int i = 6; i > 0; i--){
            Console.Write($"Now breathe out...{i}");
           // Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b \b\b\b\b\b\b\b\b\b\b");
        }*/
        List<string> _userItems = new List<string>();

        for (int j = 0; j < 4; j++){
            Console.Write(">");
            string item = Console.ReadLine();
            _userItems.Add(item);

        }

        Console.WriteLine(_userItems[0]);
        Console.WriteLine(_userItems[1]);
        Console.WriteLine(_userItems[2]);
        Console.WriteLine(_userItems[3]);

    } 

}