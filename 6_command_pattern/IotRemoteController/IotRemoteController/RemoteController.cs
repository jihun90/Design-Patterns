using IotRemoteController.Command;

namespace IotRemoteController;

public class RemoteController
{
    private ICommand[] onCommand;    
    private ICommand[] offCommand;
    private ICommand undoCommand;

    private const int COMMAND_SIZE = 7;

    public RemoteController()
    {
        onCommand =  new ICommand[7];
        offCommand =  new ICommand[7];

        undoCommand = new NoCommand();

        for(int i = 0; i<COMMAND_SIZE; i++)
        {
            onCommand[i] = new NoCommand();
            offCommand[i] = new NoCommand();
        }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        this.onCommand[slot] = onCommand;
        this.offCommand[slot] = offCommand;
    }

    public void onButtonWasPushed(int slot)
    {
        this.onCommand[slot].Execute();
        this.undoCommand = onCommand[slot];
    }

    public void offButtonWasPushed(int slot)
    {
        this.offCommand[slot].Execute();
        this.undoCommand = offCommand[slot];
    }

    public void undoButtonWasPushed()
    {
        this.undoCommand.Undo();
    }
}