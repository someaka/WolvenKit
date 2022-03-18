using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TCSInputXAxisEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public TCSInputXAxisEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
