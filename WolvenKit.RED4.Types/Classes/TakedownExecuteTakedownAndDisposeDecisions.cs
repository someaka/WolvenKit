
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownExecuteTakedownAndDisposeDecisions : LocomotionTakedownDecisions
	{
		public TakedownExecuteTakedownAndDisposeDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
