namespace WolvenKit.RED4.Types;

public partial class VendingMachineDeviceBlackboardDef : DeviceBaseBlackboardDef
{
	[Ordinal(7)] 
	[RED("ActionStatus")] 
	public gamebbScriptID_Variant ActionStatus
	{
		get => GetPropertyValue<gamebbScriptID_Variant>();
		set => SetPropertyValue<gamebbScriptID_Variant>(value);
	}

	[Ordinal(8)] 
	[RED("SoldOut")] 
	public gamebbScriptID_Bool SoldOut
	{
		get => GetPropertyValue<gamebbScriptID_Bool>();
		set => SetPropertyValue<gamebbScriptID_Bool>(value);
	}

	public VendingMachineDeviceBlackboardDef()
	{
		ActionStatus = new();
		SoldOut = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
