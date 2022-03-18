
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDebugTimeState : gameITimeState
	{
		public gameDebugTimeState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
