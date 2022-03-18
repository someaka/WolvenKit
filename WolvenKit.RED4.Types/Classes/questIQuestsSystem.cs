
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIQuestsSystem : gameIReplicatedGameSystem
	{
		public questIQuestsSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
