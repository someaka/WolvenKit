
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BasicViabilityInterpreter : IScriptable
	{
		public BasicViabilityInterpreter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
