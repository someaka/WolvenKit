
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAppearanceMeshLoadedEvent : redEvent
	{
		public entAppearanceMeshLoadedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
