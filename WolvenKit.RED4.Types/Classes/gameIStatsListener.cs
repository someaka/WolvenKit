
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIStatsListener : IScriptable
	{
		public gameIStatsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
