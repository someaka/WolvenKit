
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workIdleTransitionCommandData : workIWorkspotCommandData
	{
		public workIdleTransitionCommandData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
