
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class userSettingsVarListName : userSettingsVar
	{
		public userSettingsVarListName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
