
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questWorldStateSystem : questIWorldStateSystem
	{
		public questWorldStateSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
