
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FuseController : MasterController
	{
		public FuseController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
