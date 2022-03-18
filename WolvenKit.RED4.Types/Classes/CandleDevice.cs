
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CandleDevice : InteractiveDevice
	{
		public CandleDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
