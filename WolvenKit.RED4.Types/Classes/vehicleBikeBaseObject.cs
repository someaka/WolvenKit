
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleBikeBaseObject : vehicleWheeledBaseObject
	{
		public vehicleBikeBaseObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
