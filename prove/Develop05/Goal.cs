public class Goal{
    private string _name;
    private string _description;
    private int _points;
    private string _type;
    private bool _complete;

    public Goal(string name, string description, int points, string type, bool complete){
        _name = name;
        _description = description;
        _points = points;
        _type = type;
        _complete = complete;
    }

    public string GetName(){
        return _name;
    }
    public string GetDescription(){
        return _description;
    }
    public int GetPoints(){
        return _points;
    }
    public void SetName(){
        Console.Write("what is the name of the goal?: ");
        _name = Console.ReadLine();
    }
    public void SetDescription(){
        Console.Write("what is a short description of it?: ");
        _description = Console.ReadLine();
    }
    public void SetPoints(){
        Console.Write("what is the amount of points associated with this goal?: ");
        _points = int.Parse(Console.ReadLine());
    }
    public void SaveGoals(){
        Console.WriteLine("Goals Saved");
    }
    public void LoadGoals(){
        Console.WriteLine("Goals Loaded");
    }
    public void DisplayScore(){
        Console.WriteLine("DisplayScore");
    }
    public int CalculateScore(){
        return 0;
    }
    
    
    public virtual int EarnPoints(){
        return 0;
    }
    public virtual void DisplayGoals(){
    
    }
    public virtual int RecordEvent(){
        return 0;
    }
    public virtual bool IsCompleted(){
        return true;
    }
    public virtual string CompiledGoal(){
        return "";
    }
}