
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIObjectSelectionManager : AIObjectSelectionManagerInterface
	{
		public AIObjectSelectionManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
