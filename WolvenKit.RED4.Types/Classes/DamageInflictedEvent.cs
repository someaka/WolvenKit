
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DamageInflictedEvent : redEvent
	{
		public DamageInflictedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
