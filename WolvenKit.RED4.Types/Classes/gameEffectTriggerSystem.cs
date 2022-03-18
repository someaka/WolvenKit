
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectTriggerSystem : gameIEffectTriggerSystem
	{
		public gameEffectTriggerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
