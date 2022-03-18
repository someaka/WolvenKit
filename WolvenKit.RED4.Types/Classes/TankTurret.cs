
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TankTurret : gameWeakspotObject
	{
		public TankTurret()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
