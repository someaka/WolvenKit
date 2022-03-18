
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneCustomData_DistantShadows : SceneCustomData_DistantShadowsCommon
	{
		public SceneCustomData_DistantShadows()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
