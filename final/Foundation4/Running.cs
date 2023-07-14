public class Running : Activity{
    private int _distance;
    public Running (string date, double time, int distance) : base(date,time){
        _distance=distance;
    }
    public override double GetDistance(){
        return _distance;
    }
    public override double GetSpeed(){
        return Math.Round((60/GetPace()),2);
    }
    public override double GetPace(){
        return Math.Round((GetTime()/GetDistance()),2);
    }
    public override string GetSummary(){
        return$"{GetDate()} Running ({GetTime()}): Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
    
}