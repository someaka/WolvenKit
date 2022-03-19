namespace WolvenKit.RED4.Types;

public partial class SetDeviceUnpowered : ActionBool
{
	public SetDeviceUnpowered()
	{
		RequesterID = new();
		InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
		ActionWidgetPackage = new() { DependendActions = new() };
		CanTriggerStim = true;

		PostConstruct();
	}

	partial void PostConstruct();
}
