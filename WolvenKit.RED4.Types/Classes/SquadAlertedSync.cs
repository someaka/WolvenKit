
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SquadAlertedSync : SquadTask
	{
		public SquadAlertedSync()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
