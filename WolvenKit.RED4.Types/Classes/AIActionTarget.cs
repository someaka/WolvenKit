
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIActionTarget : IScriptable
	{
		public AIActionTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
