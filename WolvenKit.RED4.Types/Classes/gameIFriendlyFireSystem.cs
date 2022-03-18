
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIFriendlyFireSystem : gameIGameSystem
	{
		public gameIFriendlyFireSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
