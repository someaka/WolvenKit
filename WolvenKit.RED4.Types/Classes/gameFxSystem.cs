
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFxSystem : gameIFxSystem
	{
		public gameFxSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
