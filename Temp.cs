using System;

public class Swimming
{
    public int Laps { get; set; }
    public int HeartBeat { get; set; }
    public TimeSpan TimeTaken { get; set; }
}

public class Walking
{
    public int Steps { get; set; }
    public double Distance { get; set; } // Distance in kilometers
    public TimeSpan TimeTaken { get; set; }
}

public class Yoga
{
    public TimeSpan Duration { get; set; }
    public int Poses { get; set; }
    public int IntensityLevel { get; set; } // Intensity level on a scale of 1 to 10
}

public class Rowing
{
    public double Distance { get; set; } // Distance in kilometers
    public TimeSpan Duration { get; set; }
    public int StrokesPerMinute { get; set; }
}

public class Cycling
{
    public double AverageSpeed { get; set; } // Average speed in km/h
    public TimeSpan Duration { get; set; }
    public double Distance { get; set; } // Distance in kilometers
}

public class Running
{
    public double Distance { get; set; } // Distance in kilometers
    public TimeSpan Duration { get; set; }
    public TimeSpan AveragePace { get; set; } // Average pace per kilometer
}
