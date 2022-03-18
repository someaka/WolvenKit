
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Coder : BasicDistractionDevice
	{
		public Coder()
		{
			ControllerTypeName = "CoderController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
