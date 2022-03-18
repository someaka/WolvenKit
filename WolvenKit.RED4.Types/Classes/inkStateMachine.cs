
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkStateMachine : inkIStateMachine
	{
		public inkStateMachine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
