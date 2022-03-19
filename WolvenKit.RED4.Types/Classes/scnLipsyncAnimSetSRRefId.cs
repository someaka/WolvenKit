namespace WolvenKit.RED4.Types;

public partial class scnLipsyncAnimSetSRRefId : RedBaseClass
{
	[Ordinal(0)] 
	[RED("id")] 
	public CUInt32 Id
	{
		get => GetPropertyValue<CUInt32>();
		set => SetPropertyValue<CUInt32>(value);
	}

	public scnLipsyncAnimSetSRRefId()
	{
		Id = 4294967295;

		PostConstruct();
	}

	partial void PostConstruct();
}
