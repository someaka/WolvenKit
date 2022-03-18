
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineStateMachineDefinition : graphGraphDefinition
	{
		public gamestateMachineStateMachineDefinition()
		{
			Nodes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
