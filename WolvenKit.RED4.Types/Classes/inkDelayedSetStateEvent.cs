
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkDelayedSetStateEvent : redEvent
	{
		public inkDelayedSetStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
