
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class userSettingsVarListFloat : userSettingsVar
	{
		public userSettingsVarListFloat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
