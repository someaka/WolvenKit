namespace WolvenKit.RED4.Types;

public partial class ToggleON : ActionBool
{
	[Ordinal(25)] 
	[RED("TrueRecordName")] 
	public CString TrueRecordName
	{
		get => GetPropertyValue<CString>();
		set => SetPropertyValue<CString>(value);
	}

	[Ordinal(26)] 
	[RED("FalseRecordName")] 
	public CString FalseRecordName
	{
		get => GetPropertyValue<CString>();
		set => SetPropertyValue<CString>(value);
	}

	public ToggleON()
	{
		RequesterID = new();
		InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
		ActionWidgetPackage = new() { DependendActions = new() };
		CanTriggerStim = true;
		TrueRecordName = "On";
		FalseRecordName = "Off";

		PostConstruct();
	}

	partial void PostConstruct();
}
