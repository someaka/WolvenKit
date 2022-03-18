
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeDilationPSMPrereq : PlayerStateMachinePrereq
	{
		public TimeDilationPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
