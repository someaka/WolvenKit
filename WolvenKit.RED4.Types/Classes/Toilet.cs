
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Toilet : InteractiveDevice
	{
		public Toilet()
		{
			ControllerTypeName = "ToiletController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
