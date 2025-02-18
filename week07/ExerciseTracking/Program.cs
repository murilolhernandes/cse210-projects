using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();
        Activity running = new Running("Running", "03 Nov 2020", 30, 3);
        activities.Add(running);

        Activity bicycling = new Cycling("Stationary Bicycles", "03 Nov 2020", 30, 3);
        activities.Add(bicycling);

        Activity swimming = new Swimming("Swimming", "03 Nov 2020", 30, 96.6);
        activities.Add(swimming);

        Console.Clear();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}