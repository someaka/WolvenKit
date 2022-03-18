
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseInitializeEvent : redEvent
	{
		public senseInitializeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
