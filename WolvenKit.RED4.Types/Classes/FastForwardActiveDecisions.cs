
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastForwardActiveDecisions : ScenesFastForwardTransition
	{
		public FastForwardActiveDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
