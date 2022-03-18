using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNewMappinID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CUInt64 Value
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public gameNewMappinID()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
