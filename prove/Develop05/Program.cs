using System;

class Program
{
    static void Main(string[] args)
    {
        int select = 0;
        while (!(select == 6))
        {
            
            List<Goal> listGoals = new List<Goal>();

            Console.WriteLine("You have O points");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            select = int.Parse(Console.ReadLine()); 
            
            if (select == 1)
            {   
                int choice = 0;
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("which type of goal would you like to create?: ");
                choice = int.Parse(Console.ReadLine()); 
                if (choice == 1){
                    SimpleGoal simpleGoal = new SimpleGoal("","", 0,"SimpleGoal",false);
                    simpleGoal.SetName();
                    simpleGoal.SetDescription();
                    simpleGoal.SetPoints();
                    listGoals.Add(simpleGoal);                    
                }
                else if (choice == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal("","", 0,"EternalGoal",false);
                    eternalGoal.SetName();
                    eternalGoal.SetDescription();
                    eternalGoal.SetPoints();
                    listGoals.Add(eternalGoal);   
                }
                else if (choice == 3)
                {
                    CheckListGoal checkListGoal = new CheckListGoal("","", 0,"CheckListGoal",false);
                    checkListGoal.SetName();
                    checkListGoal.SetDescription();
                    checkListGoal.SetPoints();
                    listGoals.Add(checkListGoal);  
                }               
            }

            else if (select == 2)
            {
                foreach (Goal metas in listGoals){
                Console.WriteLine($"[] {metas.GetName()} ({metas.GetDescription()})");
                } 

            }

            else if (select == 3)
            {     
                Goal tuki = new Goal("","", 0,"",true);
                tuki.SaveGoals();    
            }

            else if (select == 4)
            {     
                Goal tuki = new Goal("","", 0,"",true);
                tuki.LoadGoals();       
            }
            
            else if (select == 5)
            {     
                      
            }
        }
    }
}