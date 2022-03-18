
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SlideLowGravityEvents : CrouchLowGravityEvents
	{
		public SlideLowGravityEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
