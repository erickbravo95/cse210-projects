public class Activity{
    protected string _activityName;
    protected string _description;
    protected string _duration;

    public Activity (string activityName, string description, string duration){
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public void DisplayWelcome(){
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}\n");
    }

    public void Howlong(){
        Console.Write($"How long, in seconds, would you like for your session? ");
        string userRespond = Console.ReadLine();
        _duration = userRespond;
        Console.Clear();
        Console.Write("Get ready... ");
    }
    public void DisplayBye(){
        Console.WriteLine($"Well done!!");        
    }
    public void DisplayByeAct(){
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity");
        
    }
    public void Spinner(int time){
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        
        int i = 0;

        while(DateTime.Now < endTime){
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(350);
            Console.Write("\b \b");

            i++;

            if(i >= animationStrings.Count){
                i = 0;
            }
        }     
    }
    
    public void Timer(int time){
      
        for (int j = time; j > 0; j--){
            Console.Write(j +"");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
      
    }
}