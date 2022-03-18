
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICommandsManager : AIICommandsManager
	{
		public AICommandsManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
