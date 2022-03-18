
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SelfRemovalDecisions : gamestateMachineFunctor
	{
		public SelfRemovalDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
