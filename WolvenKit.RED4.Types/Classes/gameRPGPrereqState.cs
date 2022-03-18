
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRPGPrereqState : gamePrereqState
	{
		public gameRPGPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
