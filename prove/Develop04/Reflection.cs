public class Reflection : Activity{
    public Reflection (string activityName, string description, string duration) : base(activityName,description,duration){
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }    

    public string GetRandomPrompt(){
        List<string> Prompts = new List<string>();
        Prompts.Add("Think of a time when you stood up for someone else.");
        Prompts.Add("Think of a time when you did something really difficult.");
        Prompts.Add("Think of a time when you helped someone in need.");
        Prompts.Add("Think of a time when you did something truly selfless.");
        
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(Prompts.Count);
        string Prompt = Prompts[index];
        return $" --- {Prompt} --- ";
    }

    public string GetRandomQuestion(){
        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you? ");
        questions.Add("Have you ever done anything like this before? ");
        questions.Add("How did you get started? ");
        questions.Add("How did you feel when it was complete? ");
        questions.Add("What made this time different than other times when you were not as successful? ");
        questions.Add("What is your favorite thing about this experience? ");
        questions.Add("What could you learn from this experience that applies to other situations? ");
        questions.Add("What did you learn about yourself through this experience? ");
        questions.Add("How can you keep this experience in mind in the future? ");
        
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(questions.Count);
        string question = questions[index];
        return $"> {question}";
    }

    public void RefAct(){
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as the related to this experience.");
        Console.Write("You may begin in : ");       
    }

}