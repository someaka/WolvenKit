
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NormalDeathTask : AIDeathReactionsTask
	{
		public NormalDeathTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
