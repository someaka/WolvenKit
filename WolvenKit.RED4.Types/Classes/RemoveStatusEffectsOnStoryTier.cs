
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveStatusEffectsOnStoryTier : StatusEffectTasks
	{
		public RemoveStatusEffectsOnStoryTier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
