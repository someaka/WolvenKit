
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastForwardUnavailableEvents : ScenesFastForwardTransition
	{
		public FastForwardUnavailableEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
