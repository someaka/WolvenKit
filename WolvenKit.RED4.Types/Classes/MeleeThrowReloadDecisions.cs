
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeThrowReloadDecisions : MeleeTransition
	{
		public MeleeThrowReloadDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
