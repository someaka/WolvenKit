
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTeleportationFacility : gameITeleportationFacility
	{
		public gameTeleportationFacility()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
