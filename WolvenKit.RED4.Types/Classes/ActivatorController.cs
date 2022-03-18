
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatorController : MasterController
	{
		public ActivatorController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
