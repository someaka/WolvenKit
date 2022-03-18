
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class userSettingsVar : IScriptable
	{
		public userSettingsVar()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
