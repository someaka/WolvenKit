
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIRichPresenceSystem : gameIGameSystem
	{
		public gameIRichPresenceSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
