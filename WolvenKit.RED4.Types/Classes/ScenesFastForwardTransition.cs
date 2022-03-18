
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScenesFastForwardTransition : DefaultTransition
	{
		public ScenesFastForwardTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
