
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleCarBaseObject : vehicleWheeledBaseObject
	{
		public vehicleCarBaseObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
