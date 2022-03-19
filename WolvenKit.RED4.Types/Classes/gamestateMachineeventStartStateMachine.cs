namespace WolvenKit.RED4.Types;

public partial class gamestateMachineeventStartStateMachine : redEvent
{
	[Ordinal(0)] 
	[RED("stateMachineIdentifier")] 
	public gamestateMachineStateMachineIdentifier StateMachineIdentifier
	{
		get => GetPropertyValue<gamestateMachineStateMachineIdentifier>();
		set => SetPropertyValue<gamestateMachineStateMachineIdentifier>(value);
	}

	public gamestateMachineeventStartStateMachine()
	{
		StateMachineIdentifier = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
