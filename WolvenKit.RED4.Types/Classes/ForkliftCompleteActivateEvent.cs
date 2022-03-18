
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForkliftCompleteActivateEvent : redEvent
	{
		public ForkliftCompleteActivateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
