
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIPuppetSwappedEvent : redEvent
	{
		public AIPuppetSwappedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
