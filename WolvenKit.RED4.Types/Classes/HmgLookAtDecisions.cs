
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HmgLookAtDecisions : lookAtPresetGunBaseDecisions
	{
		public HmgLookAtDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
