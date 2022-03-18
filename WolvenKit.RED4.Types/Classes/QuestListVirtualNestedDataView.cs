
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestListVirtualNestedDataView : VirtualNestedListDataView
	{
		public QuestListVirtualNestedDataView()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
