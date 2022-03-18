
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProjectileDelayEvent : redEvent
	{
		public ProjectileDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
