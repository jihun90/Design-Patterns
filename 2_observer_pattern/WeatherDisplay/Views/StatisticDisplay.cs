
using WeatherDisplay.Interface;

namespace WeatherDisplay.Views;

public class StatisticDisplay : IObserver, IDisplayElement
{
    private float maxTemp = 0.0f;
	private float minTemp = 200;
	private float tempSum= 0.0f;
	private int numReadings;
    private readonly WeatherData weatherData;

    public StatisticDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
			+ "/" + maxTemp + "/" + minTemp);
    }

    public void Update()
    {
        tempSum += weatherData.Temperature;
		numReadings++;

		if (weatherData.Temperature > maxTemp) {
			maxTemp = weatherData.Temperature;
		}
 
		if (weatherData.Temperature < minTemp) {
			minTemp = weatherData.Temperature;
		}

        Display();
    }
}