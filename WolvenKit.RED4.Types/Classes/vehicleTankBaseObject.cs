
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleTankBaseObject : vehicleBaseObject
	{
		public vehicleTankBaseObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
