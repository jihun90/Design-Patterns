using WeatherDisplay.Interface;

namespace WeatherDisplay;

public class WeatherData : ISubject
{
    private readonly List<IObserver> observers;

    public WeatherData()
    {
        observers = new List<IObserver>();
    }

    public void NotifyObservers()
    {
        observers.ForEach(observer => observer.Update());
    }

    public bool RegisterObserver(IObserver observer)
    {
        if (observer is null) return false;
        observers.Add(observer);

        return true;
    }

    public bool RemoveObserver(IObserver observer)
    {
        if (observer is null) return false;
        return observers.Remove(observer);
    }

    private void MeasurementsChaged()
    {
        NotifyObservers();
    }

    private float temperature;
    public float Temperature
    {
        get => temperature;
        set
        {
            temperature = value;
            MeasurementsChaged(); 
        }
    }
    
    private float humidity;
    public float Humidity
    {
        get => humidity;
        set
        {
            humidity = value;
            MeasurementsChaged(); 
        }
    }

    private float pressure;
    public float Pressure
    {
        get => pressure;
        set
        {
            pressure = value;
            MeasurementsChaged(); 
        }
    }    
}