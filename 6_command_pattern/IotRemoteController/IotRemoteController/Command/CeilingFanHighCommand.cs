using IotRemoteController.Remote;

namespace IotRemoteController.Command;

public class CeilingFanHighCommand  : ICommand
{
    private readonly CeilingFan ceilingFan;
    private int prevSpeed;

    public CeilingFanHighCommand (CeilingFan ceilingFan)
    {
        this.ceilingFan = ceilingFan;
    }
    public void Execute()
    {
        prevSpeed = ceilingFan.GetSpeed();
        ceilingFan.High();
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