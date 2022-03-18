
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StalkEvent : redEvent
	{
		public StalkEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
