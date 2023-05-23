public class Fraction{
    private int _top = 0;
    private int _bottom =0;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    public void GetTop(){
        Console.WriteLine(_top);
    }
    public void SetTop(int top){
        _top = top;
    }
    public void GetBottom(){
        Console.WriteLine(_bottom);
    }
    public void SetBottom(int bottom){
        _bottom = bottom;
    }
    public string GetFractionString(){
        string text = $"{_top}/{_bottom}";
        return text; 
    }
    public double GetDecimalValue(){
        double _dtop = _top;
        double _dbottom = _bottom;
        return _dtop/_dbottom;
    }
    
}

