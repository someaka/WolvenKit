namespace WolvenKit.RED4.Types;

public partial class gamestateMachineeventStopStateMachine : redEvent
{
	[Ordinal(0)] 
	[RED("stateMachineIdentifier")] 
	public gamestateMachineStateMachineIdentifier StateMachineIdentifier
	{
		get => GetPropertyValue<gamestateMachineStateMachineIdentifier>();
		set => SetPropertyValue<gamestateMachineStateMachineIdentifier>(value);
	}

	public gamestateMachineeventStopStateMachine()
	{
		StateMachineIdentifier = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
