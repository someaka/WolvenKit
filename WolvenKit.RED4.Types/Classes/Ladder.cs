
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Ladder : InteractiveDevice
	{
		public Ladder()
		{
			ControllerTypeName = "LadderController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
