
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectRemovedPrereqState : StatusEffectPrereqState
	{
		public StatusEffectRemovedPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
