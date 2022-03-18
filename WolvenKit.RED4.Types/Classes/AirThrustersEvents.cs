
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AirThrustersEvents : LocomotionAirEvents
	{
		public AirThrustersEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
