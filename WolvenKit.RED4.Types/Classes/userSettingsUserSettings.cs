
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class userSettingsUserSettings : IScriptable
	{
		public userSettingsUserSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
