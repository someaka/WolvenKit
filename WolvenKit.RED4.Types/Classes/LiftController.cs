
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LiftController : MasterController
	{
		public LiftController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
