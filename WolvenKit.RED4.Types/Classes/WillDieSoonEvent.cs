
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WillDieSoonEvent : redEvent
	{
		public WillDieSoonEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
