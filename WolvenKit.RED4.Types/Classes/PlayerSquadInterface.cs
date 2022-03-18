
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerSquadInterface : PuppetSquadInterface
	{
		public PlayerSquadInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
