
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class workItemOverrideCommandData : workIWorkspotCommandData
	{
		public workItemOverrideCommandData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
