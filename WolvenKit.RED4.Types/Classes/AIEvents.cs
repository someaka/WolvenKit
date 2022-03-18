
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIEvents : IScriptable
	{
		public AIEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
