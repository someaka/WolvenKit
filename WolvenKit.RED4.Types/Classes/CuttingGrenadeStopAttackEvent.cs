
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CuttingGrenadeStopAttackEvent : redEvent
	{
		public CuttingGrenadeStopAttackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
