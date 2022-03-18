
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DodgeAirEvents : LocomotionAirEvents
	{
		public DodgeAirEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
