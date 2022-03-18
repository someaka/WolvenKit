
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScriptStatPoolsListener : gameIStatPoolsListener
	{
		public gameScriptStatPoolsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
