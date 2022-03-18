
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownUnmountPreyDecisions : LocomotionTakedownDecisions
	{
		public TakedownUnmountPreyDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
