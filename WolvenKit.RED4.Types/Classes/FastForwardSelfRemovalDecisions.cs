
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastForwardSelfRemovalDecisions : ScenesFastForwardTransition
	{
		public FastForwardSelfRemovalDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
