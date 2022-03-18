
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkSetNextLoadingScreenEvent : redEvent
	{
		public inkSetNextLoadingScreenEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
