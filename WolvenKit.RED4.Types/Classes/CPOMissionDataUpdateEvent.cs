
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CPOMissionDataUpdateEvent : redEvent
	{
		public CPOMissionDataUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
