using IotRemoteController.Remote;

namespace IotRemoteController.Command;

public class TVOffCommand : ICommand
{
    readonly TV tv;

    public TVOffCommand(TV tv)
    {
        this.tv = tv;
    }
    public void Execute()
    {
        tv.Off();
    }

    public void Undo()
    {
        tv.On();
    }
}