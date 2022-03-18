
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LmgLookAtDecisions : lookAtPresetGunBaseDecisions
	{
		public LmgLookAtDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
