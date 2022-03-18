
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIPlayerSystem : gameIGameSystem
	{
		public gameIPlayerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
