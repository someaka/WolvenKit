namespace WolvenKit.RED4.Types;

public partial class ScoreboardEntityLogicController : inkWidgetLogicController
{
	[Ordinal(1)] 
	[RED("label")] 
	public inkTextWidgetReference Label
	{
		get => GetPropertyValue<inkTextWidgetReference>();
		set => SetPropertyValue<inkTextWidgetReference>(value);
	}

	public ScoreboardEntityLogicController()
	{
		Label = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
