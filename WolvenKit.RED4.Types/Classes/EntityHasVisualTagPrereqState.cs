
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EntityHasVisualTagPrereqState : gamePrereqState
	{
		public EntityHasVisualTagPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
