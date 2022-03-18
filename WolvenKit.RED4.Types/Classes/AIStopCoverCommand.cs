
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIStopCoverCommand : AICommand
	{
		public AIStopCoverCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
