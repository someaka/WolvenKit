
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BreachAccessPointEvent : redEvent
	{
		public BreachAccessPointEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
