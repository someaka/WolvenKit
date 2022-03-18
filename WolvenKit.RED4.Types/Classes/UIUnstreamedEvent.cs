
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIUnstreamedEvent : redEvent
	{
		public UIUnstreamedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
