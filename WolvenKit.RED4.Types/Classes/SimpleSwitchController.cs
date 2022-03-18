
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SimpleSwitchController : MasterController
	{
		public SimpleSwitchController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
