using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleSummonFinishedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<vehicleSummonState> State
		{
			get => GetPropertyValue<CEnum<vehicleSummonState>>();
			set => SetPropertyValue<CEnum<vehicleSummonState>>(value);
		}
	}
}
