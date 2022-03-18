
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetDevelopmentPointsEffector : gameEffector
	{
		public ResetDevelopmentPointsEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
