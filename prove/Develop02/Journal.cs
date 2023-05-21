public class Journal {

    public string _nameFile = "";
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry){
        _entries.Add(entry);
    }
    public void DisplayEntries(){
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void LoadFile(){
        string[] lines = System.IO.File.ReadAllLines(_nameFile);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
        
            string entry = parts[0];
            Console.WriteLine(entry);
          
        }
    }
    public void SaveToFile(){    
        using (StreamWriter outputFile = new StreamWriter(_nameFile))
        {
           foreach(Entry line in _entries){
               outputFile.WriteLine($"Date {line._date} - Prompt: {line._prompt}\n{line._response}\n");
           }   
        } 
    }
}