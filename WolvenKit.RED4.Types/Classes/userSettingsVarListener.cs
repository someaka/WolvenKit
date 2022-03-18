
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class userSettingsVarListener : IScriptable
	{
		public userSettingsVarListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
