
using WeatherDisplay.Interface;

namespace WeatherDisplay.Views;

public class ForeCastDisplay : IObserver, IDisplayElement
{
    private float currentPressure = 29.92f;  
	private float lastPressure;
    private readonly WeatherData weatherData;

    public ForeCastDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.Write("Forecast: ");
		if (currentPressure > lastPressure) {
			Console.WriteLine("Improving weather on the way!");
		} else if (currentPressure == lastPressure) {
			Console.WriteLine("More of the same");
		} else if (currentPressure < lastPressure) {
			Console.WriteLine("Watch out for cooler, rainy weather");
		}
    }

    public void Update()
    {
        lastPressure = currentPressure;
		currentPressure = weatherData.Pressure;

		Display();   
    }
}