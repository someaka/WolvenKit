
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReflectorController : BlindingLightController
	{
		public ReflectorController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
