
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDestructibleSpotsSystem : worldIDestructibleSpotsSystem
	{
		public gameDestructibleSpotsSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
