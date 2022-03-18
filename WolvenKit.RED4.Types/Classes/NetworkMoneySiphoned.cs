
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetworkMoneySiphoned : redEvent
	{
		public NetworkMoneySiphoned()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
