
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIRole : IScriptable
	{
		public AIRole()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
