
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AVComponent : VehicleComponent
	{
		public AVComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
