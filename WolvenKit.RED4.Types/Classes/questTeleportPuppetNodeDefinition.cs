namespace WolvenKit.RED4.Types;

public partial class questTeleportPuppetNodeDefinition : questAICommandNodeBase
{
	[Ordinal(2)] 
	[RED("entityReference")] 
	public CHandle<questUniversalRef> EntityReference
	{
		get => GetPropertyValue<CHandle<questUniversalRef>>();
		set => SetPropertyValue<CHandle<questUniversalRef>>(value);
	}

	[Ordinal(3)] 
	[RED("params")] 
	public CHandle<questTeleportPuppetParamsV1> Params
	{
		get => GetPropertyValue<CHandle<questTeleportPuppetParamsV1>>();
		set => SetPropertyValue<CHandle<questTeleportPuppetParamsV1>>(value);
	}

	public questTeleportPuppetNodeDefinition()
	{
		Sockets = new();
		Id = 65535;

		PostConstruct();
	}

	partial void PostConstruct();
}
