
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastForwardSelfRemovalEvents : ScenesFastForwardTransition
	{
		public FastForwardSelfRemovalEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
