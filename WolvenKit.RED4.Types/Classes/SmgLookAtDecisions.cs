
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmgLookAtDecisions : lookAtPresetGunBaseDecisions
	{
		public SmgLookAtDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
