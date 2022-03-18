
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReflectorControllerPS : BlindingLightControllerPS
	{
		public ReflectorControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
