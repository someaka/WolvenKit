
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class userSettingsGroup : IScriptable
	{
		public userSettingsGroup()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
