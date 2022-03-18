
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReloadDecisions : WeaponTransition
	{
		public ReloadDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
