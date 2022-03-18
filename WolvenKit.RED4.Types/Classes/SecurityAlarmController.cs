
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAlarmController : MasterController
	{
		public SecurityAlarmController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
