
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleWheeledBaseObject : vehicleBaseObject
	{
		public vehicleWheeledBaseObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
