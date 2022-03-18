
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestListVirtualNestedListController : VirtualNestedListController
	{
		public QuestListVirtualNestedListController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
