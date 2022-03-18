
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIScriptSquad : IScriptable
	{
		public AIScriptSquad()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
