
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerHostileThreatDetected : AIHostileThreatDetected
	{
		public PlayerHostileThreatDetected()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
