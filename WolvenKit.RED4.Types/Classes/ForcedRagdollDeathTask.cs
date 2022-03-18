
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForcedRagdollDeathTask : AIDeathReactionsTask
	{
		public ForcedRagdollDeathTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
