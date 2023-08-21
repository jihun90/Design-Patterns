using IotRemoteController.Remote;

namespace IotRemoteController.Command;

public class CeilingFanOffCommand : ICommand
{
    private readonly CeilingFan ceilingFan;
    private int prevSpeed;

    public CeilingFanOffCommand(CeilingFan ceilingFan)
    {
        this.ceilingFan = ceilingFan;
    }
    public void Execute()
    {
        prevSpeed = ceilingFan.GetSpeed();
        ceilingFan.Off();
    }

    public void Undo()
    {
        switch(prevSpeed)
        {
            case CeilingFan.HIGH : ceilingFan.High(); break;
            case CeilingFan.MEDIUM : ceilingFan.Medium(); break;
            case CeilingFan.LOW : ceilingFan.Low(); break;
            default: ceilingFan.Off(); break;
        }
    }
}