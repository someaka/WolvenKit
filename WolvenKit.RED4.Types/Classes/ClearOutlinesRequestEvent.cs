
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClearOutlinesRequestEvent : redEvent
	{
		public ClearOutlinesRequestEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
