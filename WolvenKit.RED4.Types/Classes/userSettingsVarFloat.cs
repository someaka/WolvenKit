
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class userSettingsVarFloat : userSettingsVar
	{
		public userSettingsVarFloat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
