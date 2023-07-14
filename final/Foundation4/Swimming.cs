public class Swimming : Activity{
    private int _laps;
    public Swimming (string date, double time, int laps) : base(date,time){
        _laps=laps;
    }
    public override double GetDistance(){
        return Math.Round((_laps*50)/(1000*0.62),2);
    }
    public override double GetSpeed(){
        return Math.Round((GetDistance()/GetTime())*60,2);
    }
    public override double GetPace(){
        return Math.Round((GetTime()/GetDistance()),2);
    }
    public override string GetSummary(){
        return$"{GetDate()} Swimming ({GetTime()}): Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
    
}