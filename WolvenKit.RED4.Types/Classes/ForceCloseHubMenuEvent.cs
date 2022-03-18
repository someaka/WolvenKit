
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceCloseHubMenuEvent : redEvent
	{
		public ForceCloseHubMenuEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
