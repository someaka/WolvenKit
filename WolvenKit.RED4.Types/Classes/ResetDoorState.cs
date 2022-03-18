
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetDoorState : redEvent
	{
		public ResetDoorState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
