
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DOTContinuousEffector : gameContinuousEffector
	{
		public DOTContinuousEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
