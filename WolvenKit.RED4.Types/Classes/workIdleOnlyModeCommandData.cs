
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workIdleOnlyModeCommandData : workIWorkspotCommandData
	{
		public workIdleOnlyModeCommandData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
