
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsTargetFilter_Logical : gametargetingSystemTargetFilter_Closest
	{
		public gameinteractionsTargetFilter_Logical()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
