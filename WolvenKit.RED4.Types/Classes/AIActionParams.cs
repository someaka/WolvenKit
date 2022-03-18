
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIActionParams : IScriptable
	{
		public AIActionParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
