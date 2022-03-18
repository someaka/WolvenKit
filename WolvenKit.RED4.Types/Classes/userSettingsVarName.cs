
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class userSettingsVarName : userSettingsVar
	{
		public userSettingsVarName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
