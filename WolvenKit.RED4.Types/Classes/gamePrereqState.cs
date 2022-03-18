
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePrereqState : IScriptable
	{
		public gamePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
