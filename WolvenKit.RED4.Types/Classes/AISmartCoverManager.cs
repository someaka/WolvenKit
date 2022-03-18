
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISmartCoverManager : AIISmartCoverManager
	{
		public AISmartCoverManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
