
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIGenericLookatTask : AILookatTask
	{
		public AIGenericLookatTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
