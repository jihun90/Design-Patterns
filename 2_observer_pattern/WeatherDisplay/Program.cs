using WeatherDisplay.Views;

namespace WeatherDisplay;

class Program{
    static void Main()
    {
        WeatherData weatherData = new();
        
        _ = new CurrentConditionsDisplay(weatherData);
        _ = new StatisticDisplay(weatherData);
        _ = new ForeCastDisplay(weatherData);

        weatherData.Temperature = 80;
        weatherData.Humidity = 65;
        weatherData.Pressure = 29.2f;
        weatherData.Temperature = 90;
    }
}