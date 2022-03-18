
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WithoutHitDataDeathTask : AIDeathReactionsTask
	{
		public WithoutHitDataDeathTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
