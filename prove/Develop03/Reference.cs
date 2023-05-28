public class Reference{
    private string _name;
    private int _chapter;
    private int _StartVerse;
    private int _EndVerse;

    public Reference (){
        _name = "Romans";
        _chapter = 8;
        _StartVerse = 38;
        _EndVerse = 39;
    }
    
    public Reference (string name, int chapter, int verse){
        _name = name;
        _chapter = chapter;
        _StartVerse = verse;
        _EndVerse = verse;
    }

    public Reference (string name, int chapter, int startVerse, int endVerse){
        _name = name;
        _chapter = chapter;
        _StartVerse = startVerse;
        _EndVerse = endVerse;
    }
    
    public string GetReference(){
        if (_StartVerse == _EndVerse){
            return $"{_name} {_chapter}:{_StartVerse} ";            
        }
        else{
            return $"{_name} {_chapter}:{_StartVerse}-{_EndVerse} ";
        }

    }
}


