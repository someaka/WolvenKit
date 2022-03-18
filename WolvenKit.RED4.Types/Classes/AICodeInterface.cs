
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICodeInterface : IScriptable
	{
		public AICodeInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
