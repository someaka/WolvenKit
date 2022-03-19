namespace WolvenKit.RED4.Types;

public partial class ResetTimeDilation : redEvent
{
	[Ordinal(0)] 
	[RED("easeOut")] 
	public CName EaseOut
	{
		get => GetPropertyValue<CName>();
		set => SetPropertyValue<CName>(value);
	}

	public ResetTimeDilation()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
