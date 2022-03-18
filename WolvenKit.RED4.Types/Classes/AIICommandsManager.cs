
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIICommandsManager : gameIGameSystem
	{
		public AIICommandsManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
