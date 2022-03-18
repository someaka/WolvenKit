
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class userSettingsVarBool : userSettingsVar
	{
		public userSettingsVarBool()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
