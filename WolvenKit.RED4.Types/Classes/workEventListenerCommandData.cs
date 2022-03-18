
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workEventListenerCommandData : workIWorkspotCommandData
	{
		public workEventListenerCommandData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
