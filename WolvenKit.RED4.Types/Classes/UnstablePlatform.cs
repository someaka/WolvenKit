
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnstablePlatform : BaseAnimatedDevice
	{
		public UnstablePlatform()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
