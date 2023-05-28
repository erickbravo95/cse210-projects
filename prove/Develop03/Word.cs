public class Word{
   
    private string _text;

    public Word(){
        _text = "For I am persuaded, that neither death, nor life, nor angels, nor principalities, nor powers, nor things present, nor things to come; Nor height, nor depth, nor any other creature, shall be able to separate us from the love of God, which is in Christ Jesus our Lord.";
    }    
          
     public string getHiddenWords(){

       string[] words = _text.Split(' ');
       Random random = new Random();

       int randomNumber = random.Next(0, words.Length);
       int randomNumber1 = random.Next(0, words.Length);
       int randomNumber2 = random.Next(0, words.Length);
       int index = random.Next(0, words.Length);
    
       foreach(string item in words)
        {
          Console.Write(item);                 
        }
   
        words[randomNumber] =  "___ ";
        words[randomNumber1] =  "___ ";
        words[randomNumber2] =  "___ ";

       return _text = string.Join(' ', words);
    }

}