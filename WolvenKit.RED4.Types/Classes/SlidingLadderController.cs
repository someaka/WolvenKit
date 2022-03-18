
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SlidingLadderController : BaseAnimatedDeviceController
	{
		public SlidingLadderController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
