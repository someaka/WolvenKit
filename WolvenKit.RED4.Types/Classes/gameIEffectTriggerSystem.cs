
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIEffectTriggerSystem : gameIGameSystem
	{
		public gameIEffectTriggerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
