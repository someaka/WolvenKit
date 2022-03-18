
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZonesPSMPrereq : PlayerStateMachinePrereq
	{
		public ZonesPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
