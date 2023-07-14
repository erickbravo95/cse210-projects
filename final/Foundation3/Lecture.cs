public class Lecture : Event{
    private string _speaker;
    private int _capacity;
    public Lecture (string type,string title,string description, string date, string time,Address address,string speaker, int capacity) : base(type,title,description,date,time,address){
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetSpeaker(){
        return _speaker;
    }
    public int GetCapacity(){
        return _capacity;
    }
    public override void FullDetails(){
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"Speaker: {GetSpeaker()}");
        Console.WriteLine($"Capacity: {GetCapacity()}");
    }
}