
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISmartObjectManager : AIISmartObjectManager
	{
		public AISmartObjectManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
