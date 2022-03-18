
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DialogHubPostInitializeEvent : redEvent
	{
		public DialogHubPostInitializeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
