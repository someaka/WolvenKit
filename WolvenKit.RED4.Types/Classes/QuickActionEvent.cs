
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickActionEvent : redEvent
	{
		public QuickActionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
