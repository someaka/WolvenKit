
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workRegisterCleanupCommandData : workIWorkspotCommandData
	{
		public workRegisterCleanupCommandData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
