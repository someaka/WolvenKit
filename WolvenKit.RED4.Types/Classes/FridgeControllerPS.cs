using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FridgeControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FridgeControllerPS()
		{
			DeviceName = "LocKey#79";
			TweakDBRecord = new() { Value = 63072019199 };
			TweakDBDescriptionRecord = new() { Value = 115920876132 };
		}
	}
}
