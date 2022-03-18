
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineStateDefinition : graphGraphNodeDefinition
	{
		public gamestateMachineStateDefinition()
		{
			Sockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
