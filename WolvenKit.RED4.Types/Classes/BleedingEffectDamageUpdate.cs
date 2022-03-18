
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BleedingEffectDamageUpdate : redEvent
	{
		public BleedingEffectDamageUpdate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
