
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeBlockDecisions : MeleeTransition
	{
		public MeleeBlockDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
