namespace WolvenKit.RED4.Types;

public partial class gameEffectOutputParameter_Variant : RedBaseClass
{
	[Ordinal(0)] 
	[RED("blackboardProperty")] 
	public gameBlackboardPropertyBindingDefinition BlackboardProperty
	{
		get => GetPropertyValue<gameBlackboardPropertyBindingDefinition>();
		set => SetPropertyValue<gameBlackboardPropertyBindingDefinition>(value);
	}

	public gameEffectOutputParameter_Variant()
	{
		BlackboardProperty = new() { SerializableID = new(), PropertyPath = new() };

		PostConstruct();
	}

	partial void PostConstruct();
}
