
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsPublisherBaseEvent : RedBaseClass
	{
		public gameinteractionsPublisherBaseEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
