
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIISmartObjectManager : gameIGameSystem
	{
		public AIISmartObjectManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
