
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetrunnerChair : InteractiveDevice
	{
		public NetrunnerChair()
		{
			ControllerTypeName = "NetrunnerChairController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
