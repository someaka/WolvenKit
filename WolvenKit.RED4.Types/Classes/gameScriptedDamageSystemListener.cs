
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScriptedDamageSystemListener : gameIDamageSystemListener
	{
		public gameScriptedDamageSystemListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
