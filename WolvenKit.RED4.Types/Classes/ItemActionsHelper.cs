
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemActionsHelper : IScriptable
	{
		public ItemActionsHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
