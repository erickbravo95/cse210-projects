public class Breathing : Activity{
    
    public Breathing (string activityName, string description, string duration) : base(activityName,description,duration){
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public void BreathIn(){
        Console.Write("Breathe in...");
    }
    public void BreathOut(){
        Console.Write($"Now breathe out...");
    }
}
