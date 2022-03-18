
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitShieldEvent : redEvent
	{
		public HitShieldEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
