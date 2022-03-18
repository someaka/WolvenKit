
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastForwardActiveEvents : ScenesFastForwardTransition
	{
		public FastForwardActiveEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
