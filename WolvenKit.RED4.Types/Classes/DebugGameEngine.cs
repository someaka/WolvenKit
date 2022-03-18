
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DebugGameEngine : CGameEngine
	{
		public DebugGameEngine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
