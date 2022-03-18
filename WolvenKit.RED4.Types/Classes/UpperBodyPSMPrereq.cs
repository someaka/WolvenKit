
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpperBodyPSMPrereq : PlayerStateMachinePrereq
	{
		public UpperBodyPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
