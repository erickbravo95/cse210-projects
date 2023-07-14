public class Outdoor : Event{
    private string _weather;
    public Outdoor (string type,string title,string description, string date, string time,Address address,string weather) : base(type,title,description,date,time,address){
        _weather = weather;
    }
    public string WeatherInfo(){
        return _weather;
    }
    public override void FullDetails(){
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"Weather: {WeatherInfo()}");
    }
}