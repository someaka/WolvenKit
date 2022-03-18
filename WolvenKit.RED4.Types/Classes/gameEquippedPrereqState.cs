
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEquippedPrereqState : gamePrereqState
	{
		public gameEquippedPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
