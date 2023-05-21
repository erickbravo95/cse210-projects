public class Entry {

    public string _date = "";
    public string _response = "";
    public string _prompt = "";
    
    
  /*public string Response(){
        
    }*/

    public void Display(){
       Console.WriteLine($"Date {_date} - Prompt: {_prompt}\n{_response}\n");
    }    
}