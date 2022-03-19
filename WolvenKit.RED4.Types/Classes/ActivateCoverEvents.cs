namespace WolvenKit.RED4.Types;

public partial class ActivateCoverEvents : CoverActionEventsTransition
{
	[Ordinal(3)] 
	[RED("usingCover")] 
	public CBool UsingCover
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public ActivateCoverEvents()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
