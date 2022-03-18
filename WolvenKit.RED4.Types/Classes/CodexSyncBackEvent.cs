
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexSyncBackEvent : redEvent
	{
		public CodexSyncBackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
