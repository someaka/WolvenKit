
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameObjectCarrierComponentDetached : redEvent
	{
		public gameObjectCarrierComponentDetached()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
