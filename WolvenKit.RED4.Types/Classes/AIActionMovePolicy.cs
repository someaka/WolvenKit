
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIActionMovePolicy : IScriptable
	{
		public AIActionMovePolicy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
