
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityTurretOffline : redEvent
	{
		public SecurityTurretOffline()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
