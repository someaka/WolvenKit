
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameObjectCarrierComponentAttached : redEvent
	{
		public gameObjectCarrierComponentAttached()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
