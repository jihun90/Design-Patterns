namespace WeatherDisplay.Interface;

public interface ISubject
{
    bool RegisterObserver(IObserver observer);
    bool RemoveObserver(IObserver observer);
    void NotifyObservers();
}