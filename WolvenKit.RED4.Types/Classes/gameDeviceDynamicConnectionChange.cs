
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeviceDynamicConnectionChange : redEvent
	{
		public gameDeviceDynamicConnectionChange()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
