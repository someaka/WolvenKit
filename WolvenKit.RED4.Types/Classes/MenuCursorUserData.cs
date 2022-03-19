namespace WolvenKit.RED4.Types;

public partial class MenuCursorUserData : inkUserData
{
	[Ordinal(0)] 
	[RED("animationOverride")] 
	public CName AnimationOverride
	{
		get => GetPropertyValue<CName>();
		set => SetPropertyValue<CName>(value);
	}

	[Ordinal(1)] 
	[RED("actions")] 
	public CArray<CName> Actions
	{
		get => GetPropertyValue<CArray<CName>>();
		set => SetPropertyValue<CArray<CName>>(value);
	}

	public MenuCursorUserData()
	{
		Actions = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
