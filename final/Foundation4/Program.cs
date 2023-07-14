using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running("16/05/2023",30,8);
        Swimming swimming = new Swimming("16/05/2023",30,15);
        Cycling cycling = new Cycling("16/05/2023",30,9);

        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);
        
        foreach (Activity activity in activities){
            Console.WriteLine(activity.GetSummary());
        }

    }
}