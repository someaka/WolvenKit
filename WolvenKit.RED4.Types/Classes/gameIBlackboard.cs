
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIBlackboard : IScriptable
	{
		public gameIBlackboard()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
