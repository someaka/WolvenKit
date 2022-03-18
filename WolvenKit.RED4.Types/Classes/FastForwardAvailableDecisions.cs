
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastForwardAvailableDecisions : ScenesFastForwardTransition
	{
		public FastForwardAvailableDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
