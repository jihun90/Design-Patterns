using IotRemoteController.Remote;

namespace IotRemoteController.Command;

public class MacroCommand : ICommand
{
    readonly ICommand[] commands;

    public MacroCommand(ICommand[] commands)
    {
        this.commands = commands;
    }
    public void Execute()
    {
        foreach (var command in commands)
        {
            command.Execute();
        }
    }

    public void Undo()
    {
        for (int i = commands.Length - 1; i >= 0 ; i--)
        {
            commands[i].Undo();   
        }
    }
}