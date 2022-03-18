
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickHackEvent : redEvent
	{
		public QuickHackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
