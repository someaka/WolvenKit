
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkDelayedSetLoadingScreenEvent : redEvent
	{
		public inkDelayedSetLoadingScreenEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
