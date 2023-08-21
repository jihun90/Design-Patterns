using IotRemoteController.Remote;

namespace IotRemoteController.Command;

public class LightOffCommand : ICommand
{
    readonly Light light;

    public LightOffCommand(Light light)
    {
        this.light = light;
    }
    public void Execute()
    {
        light.Off();
    }

    public void Undo()
    {
        light.On();
    }
}