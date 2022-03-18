
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeRecoveryEvents : MeleeNotReadyEvents
	{
		public MeleeRecoveryEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
