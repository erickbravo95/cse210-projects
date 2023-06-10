public class Listing : Activity{
    public List<string> _userEntries = new List<string>();
    public Listing (string activityName, string description, string duration) : base(activityName,description,duration){
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }
    public string GetRandomPrompt(){
        List<string> Prompts = new List<string>();
        Prompts.Add("Who are people that you appreciate?");
        Prompts.Add("What are personal strengths of yours?");
        Prompts.Add("Who are people that you have helped this week?");
        Prompts.Add("When have you felt the Holy Ghost this month?");
        Prompts.Add("Who are some of your personal heroes?");
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(Prompts.Count);
        string Prompt = Prompts[index];
        return $" --- {Prompt} --- ";
    }
    public void LisAct(){
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in : ");       
    }
    
    public List<string> GetUserEntries(){    
        Console.Write(">");
        string Entry = Console.ReadLine();
        _userEntries.Add(Entry);
        return _userEntries;
    }

    public void EntriesSum(List<string>_userEntries){
        Console.WriteLine($"You listed {_userEntries.Count} items");
    }
}