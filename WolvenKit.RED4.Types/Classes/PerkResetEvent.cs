
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerkResetEvent : redEvent
	{
		public PerkResetEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
