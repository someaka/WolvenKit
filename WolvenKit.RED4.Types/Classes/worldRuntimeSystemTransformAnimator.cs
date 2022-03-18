
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemTransformAnimator : worldIRuntimeSystem
	{
		public worldRuntimeSystemTransformAnimator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
