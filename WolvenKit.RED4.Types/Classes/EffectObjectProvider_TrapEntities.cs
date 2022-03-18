
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectObjectProvider_TrapEntities : gameEffectObjectProvider_Scripted
	{
		public EffectObjectProvider_TrapEntities()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
