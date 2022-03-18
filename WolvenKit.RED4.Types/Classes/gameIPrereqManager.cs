
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIPrereqManager : gameIGameSystem
	{
		public gameIPrereqManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
