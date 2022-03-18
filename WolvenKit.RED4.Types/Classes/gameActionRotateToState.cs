
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionRotateToState : gameActionRotateBaseState
	{
		public gameActionRotateToState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
