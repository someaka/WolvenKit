
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameItemDecorationEvent : redEvent
	{
		public gameItemDecorationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
