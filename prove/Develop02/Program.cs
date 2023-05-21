using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        int select = 0;
        
        Journal journal = new Journal();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        
        Console.WriteLine("Welcome to the Journal Program!");
        
        while (!(select == 5))
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            select = int.Parse(Console.ReadLine()); 
            
            if (select == 1)
            {   
                Promptgenerator promptResult = new Promptgenerator();
                Console.WriteLine(promptResult.GetPrompt());
                Console.Write("> ");
                string entry = Console.ReadLine();

                Entry entry1 = new Entry();
                entry1._date = dateText;
                entry1._response = entry;
                entry1._prompt = promptResult.GetPrompt();            

                journal.AddEntry(entry1);
                
            }

            else if (select == 2)
            {
                journal.DisplayEntries();
            }

            else if (select == 3)
            {     
                Console.WriteLine("What is the filename?");
                string answer = Console.ReadLine();
                
                journal._nameFile = answer;
                journal.LoadFile(); 
            }

            else if (select == 4)
            {
                Console.WriteLine("What is the filename?");
                string answer = Console.ReadLine();
                
                journal._nameFile = answer;
                journal.SaveToFile();            
            }    

            else
            {
			    Console.WriteLine("Wrong answer, please try again.");
            }
        }
    }
}