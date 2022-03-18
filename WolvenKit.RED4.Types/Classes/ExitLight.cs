
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExitLight : ElectricLight
	{
		public ExitLight()
		{
			ControllerTypeName = "ExitLightController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
