
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BasicInteractionInterpreter : IScriptable
	{
		public BasicInteractionInterpreter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
