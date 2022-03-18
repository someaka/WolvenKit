
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScriptStatusEffectListener : gameIStatusEffectListener
	{
		public gameScriptStatusEffectListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
