
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeNotReadyDecisions : MeleeTransition
	{
		public MeleeNotReadyDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
