
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProjectileBreachEvent : redEvent
	{
		public ProjectileBreachEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
