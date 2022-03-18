
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_Scripted : gameEffectExecutor
	{
		public gameEffectExecutor_Scripted()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
