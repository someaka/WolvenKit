
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePrereqManager : gameIPrereqManager
	{
		public gamePrereqManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
