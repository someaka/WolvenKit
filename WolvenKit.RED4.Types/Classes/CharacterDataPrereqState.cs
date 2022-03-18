
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CharacterDataPrereqState : gamePrereqState
	{
		public CharacterDataPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
