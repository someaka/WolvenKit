
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterAllMappinsEvent : redEvent
	{
		public UnregisterAllMappinsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
