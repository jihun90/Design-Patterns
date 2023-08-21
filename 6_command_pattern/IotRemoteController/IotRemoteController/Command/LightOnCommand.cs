using IotRemoteController.Remote;

namespace IotRemoteController.Command;

public class LightOnCommand : ICommand
{
    readonly Light light;
    public LightOnCommand(Light light)
    {
        this.light = light;
    }
    public void Execute()
    {
        light.On();
    }

    public void Undo()
    {
        light.Off();
    }
}