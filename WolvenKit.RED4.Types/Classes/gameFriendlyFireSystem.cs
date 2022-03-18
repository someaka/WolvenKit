
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFriendlyFireSystem : gameIFriendlyFireSystem
	{
		public gameFriendlyFireSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
