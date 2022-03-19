namespace WolvenKit.RED4.Types;

public partial class gameEffectInputParameter_Variant : RedBaseClass
{
	[Ordinal(0)] 
	[RED("blackboardProperty")] 
	public gameBlackboardPropertyBindingDefinition BlackboardProperty
	{
		get => GetPropertyValue<gameBlackboardPropertyBindingDefinition>();
		set => SetPropertyValue<gameBlackboardPropertyBindingDefinition>(value);
	}

	public gameEffectInputParameter_Variant()
	{
		BlackboardProperty = new() { SerializableID = new(), PropertyPath = new() };

		PostConstruct();
	}

	partial void PostConstruct();
}
