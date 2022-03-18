
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questShowPointOfNoReturnPromptEvent : redEvent
	{
		public questShowPointOfNoReturnPromptEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
