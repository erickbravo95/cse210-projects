public abstract class Activity{
    private string _date;
    private double _time;
    public Activity (string date, double time){
        _date = date;
        _time = time;
    }
    public string GetDate(){
        return _date;
    }
    public double GetTime(){
        return _time;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary(){
        return$"{GetDate()} Running ({GetTime()}): Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
    
}