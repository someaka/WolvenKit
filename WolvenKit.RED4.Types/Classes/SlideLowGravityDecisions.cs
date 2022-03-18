
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SlideLowGravityDecisions : CrouchLowGravityDecisions
	{
		public SlideLowGravityDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
