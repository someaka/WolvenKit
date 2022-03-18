
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDevicePSChanged : redEvent
	{
		public gameDevicePSChanged()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
