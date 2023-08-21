using IotRemoteController;
using IotRemoteController.Command;
using IotRemoteController.Remote;


RemoteController remoteController = new RemoteController();

Light livingRoomLight = new Light("Living Room");
CeilingFan ceilingFan = new CeilingFan("Room");
TV tv = new TV("Room2");

ICommand LightOnCommand = new LightOnCommand(livingRoomLight);
ICommand LightOffCommand = new LightOffCommand(livingRoomLight);
ICommand CeilingOnCommand = new CeilingFanHighCommand(ceilingFan);
ICommand CeilingOffCommand = new CeilingFanOffCommand(ceilingFan);
ICommand TVOnCommand = new TVOnCommand(tv);
ICommand TVOffCommand = new TVOffCommand(tv);

remoteController.SetCommand(0, LightOnCommand, LightOffCommand);

remoteController.onButtonWasPushed(0);
remoteController.offButtonWasPushed(0);
remoteController.undoButtonWasPushed();

ICommand[] MacroOnCommand = { LightOnCommand, CeilingOnCommand, TVOnCommand};
ICommand[] MacroOffCommand = { LightOffCommand, CeilingOffCommand, TVOffCommand};

MacroCommand partyOnCommand = new MacroCommand(MacroOnCommand);
MacroCommand partyOffCommand = new MacroCommand(MacroOffCommand);

remoteController.SetCommand(2, partyOnCommand, partyOffCommand);
Console.WriteLine("Party Time");
remoteController.onButtonWasPushed(2);
Console.WriteLine("Party End");
remoteController.offButtonWasPushed(2);