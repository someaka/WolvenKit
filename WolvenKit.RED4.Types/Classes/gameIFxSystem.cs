
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIFxSystem : gameIGameSystem
	{
		public gameIFxSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
