
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PersonnelSystemController : DeviceSystemBaseController
	{
		public PersonnelSystemController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
