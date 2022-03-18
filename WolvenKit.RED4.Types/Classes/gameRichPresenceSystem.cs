
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRichPresenceSystem : gameIRichPresenceSystem
	{
		public gameRichPresenceSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
