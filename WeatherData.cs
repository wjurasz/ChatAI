public class WeatherData
{
    public CurrentWeather Current { get; set; }
    public Location Location { get; set; }
}

public class CurrentWeather
{
    public double Temp_C { get; set; }
    public double Feelslike_C { get; set; }
    public double Humidity { get; set; }
    public Condition Condition { get; set; }
}

public class Condition
{
    public string Text { get; set; }
    public string Icon { get; set; }
}

public class Location
{
    public string Name { get; set; }
    public string Country { get; set; }
}
