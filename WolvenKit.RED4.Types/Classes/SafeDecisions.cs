
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SafeDecisions : WeaponTransition
	{
		public SafeDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
