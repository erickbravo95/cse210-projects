public class Reception : Event{
    private string _rsvpEmail;
    public Reception (string type,string title,string description, string date, string time,Address address,string rsvpEmail) : base(type,title,description,date,time,address){
        _rsvpEmail = rsvpEmail;
    } 
    public string GetEmail(){
        return _rsvpEmail;
    }
    public override void FullDetails(){
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"Email: {GetEmail()}");
    }
}