public class Scripture{
    private Word _text;
    private Reference _reference;

    public Scripture(){
        _text = new Word();
        _reference = new Reference();
    }

    public Scripture(string text,Reference reference){
        _text = new Word();
        _reference = new Reference();
    }
    
    public string GetScripture(){ 
        return $"{_reference.GetReference()}";
       // return $"{_reference.GetReference() }{_text.getHiddenWords()}";
    }
}