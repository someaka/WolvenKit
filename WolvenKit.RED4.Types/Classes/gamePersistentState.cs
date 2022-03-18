
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePersistentState : IScriptable
	{
		public gamePersistentState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
