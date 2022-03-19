namespace WolvenKit.RED4.Types;

public partial class interopGlobalNodeIDInfo : RedBaseClass
{
	[Ordinal(0)] 
	[RED("globalName")] 
	public CString GlobalName
	{
		get => GetPropertyValue<CString>();
		set => SetPropertyValue<CString>(value);
	}

	[Ordinal(1)] 
	[RED("globalNodeIDPath")] 
	public CString GlobalNodeIDPath
	{
		get => GetPropertyValue<CString>();
		set => SetPropertyValue<CString>(value);
	}

	[Ordinal(2)] 
	[RED("globalNodeIDHash")] 
	public CUInt64 GlobalNodeIDHash
	{
		get => GetPropertyValue<CUInt64>();
		set => SetPropertyValue<CUInt64>(value);
	}

	[Ordinal(3)] 
	[RED("globalNameIsAutoGenerated")] 
	public CBool GlobalNameIsAutoGenerated
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public interopGlobalNodeIDInfo()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
