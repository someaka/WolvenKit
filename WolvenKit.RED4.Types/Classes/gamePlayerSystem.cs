
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerSystem : gameIPlayerSystem
	{
		public gamePlayerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
