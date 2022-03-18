
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAnimationSystem : worldIRuntimeSystem
	{
		public worldAnimationSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
