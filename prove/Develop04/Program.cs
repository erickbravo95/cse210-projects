using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int select = 0;
       while (!(select == 4))
        {
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            select = int.Parse(Console.ReadLine()); 
            Console.Clear();
            
            if (select == 1)
            {   
                Breathing act = new Breathing("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.","300");
                act.DisplayWelcome();
                act.Howlong();
                Console.WriteLine();
                act.Spinner(5);
                Console.WriteLine();
                for (int j = 0; j < 4; j++){
                    act.BreathIn();
                    act.Timer(4);
                    Console.WriteLine();
                    act.BreathOut();
                    act.Timer(6);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                act.DisplayBye(); 
                act.Spinner(5);
                Console.WriteLine();  
                act.DisplayByeAct(); 
                act.Spinner(5);
                Console.Clear();                     
            }

            else if (select == 2)
            {
                Reflection act = new Reflection("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.","300");
                act.DisplayWelcome();
                act.Howlong();
                Console.WriteLine();
                act.Spinner(5);
                Console.WriteLine();

                act.RefAct();
                act.Timer(5);
                Console.Clear(); 

                Console.Write(act.GetRandomQuestion());
                act.Spinner(15);
                Console.WriteLine();
                Console.Write(act.GetRandomQuestion());
                act.Spinner(15);
                Console.WriteLine();
                Console.WriteLine();

                act.DisplayBye(); 
                act.Spinner(5);
                Console.WriteLine();  
                act.DisplayByeAct(); 
                act.Spinner(5);
                Console.Clear();   
            }

            else if (select == 3)
            {     
                Listing act = new Listing("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.","300");
                act.DisplayWelcome();
                act.Howlong();
                Console.WriteLine();
                act.Spinner(5);
                Console.WriteLine();
                
                act.LisAct();
                act.Timer(5);
                Console.WriteLine();
                for (int j = 0; j < 4; j++){
                    act.GetUserEntries();                 
                }
                act.EntriesSum(act._userEntries);
                Console.WriteLine();
                act.DisplayBye(); 
                act.Spinner(5);
                Console.WriteLine();  
                act.DisplayByeAct(); 
                act.Spinner(5);
                Console.Clear();      
            }
        }
    }
}