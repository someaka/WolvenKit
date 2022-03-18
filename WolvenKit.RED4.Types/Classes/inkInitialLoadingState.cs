
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkInitialLoadingState : inkIStateMachineState
	{
		public inkInitialLoadingState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
