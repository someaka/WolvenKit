
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectObjectProvider_PhysicalCollisionTrapEntities : gameEffectObjectProvider_Scripted
	{
		public EffectObjectProvider_PhysicalCollisionTrapEntities()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
