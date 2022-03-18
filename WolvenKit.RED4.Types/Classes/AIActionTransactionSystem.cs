
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIActionTransactionSystem : IScriptable
	{
		public AIActionTransactionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
