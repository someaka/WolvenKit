
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameWaypoint : worldIMarker
	{
		public gameWaypoint()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
