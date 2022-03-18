
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RestoreRevealStateEvent : redEvent
	{
		public RestoreRevealStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
