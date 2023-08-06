using WeatherDisplay.Views;

namespace WeatherDisplay;

class Program{
    static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();
        
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        StatisticDisplay statisticDisplay = new StatisticDisplay(weatherData);
        ForeCastDisplay foreCastDisplay = new ForeCastDisplay(weatherData);

        weatherData.Temperature = 80;
        weatherData.Humidity = 65;
        weatherData.Pressure = 29.2f;
        weatherData.Temperature = 90;
    }
}