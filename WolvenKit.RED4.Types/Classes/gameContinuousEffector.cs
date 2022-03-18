
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameContinuousEffector : gameEffector
	{
		public gameContinuousEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
