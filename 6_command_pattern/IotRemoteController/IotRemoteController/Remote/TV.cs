namespace IotRemoteController.Remote;

public class TV
{
    private string location = "";
    private int channel;

    public TV(string location)
    {
        this.location = location;
    }

    public void On()
    {
        Console.WriteLine(location + " TV is on");
    }

    public void Off()
    {
        Console.WriteLine(location + " TV is off");
    }

    public void SetInputChannel()
    {
		this.channel = 3;
		Console.WriteLine(location + " TV channel is set " + channel);
    }
}