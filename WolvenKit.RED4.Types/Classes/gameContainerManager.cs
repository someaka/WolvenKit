
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameContainerManager : gameIContainerManager
	{
		public gameContainerManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
