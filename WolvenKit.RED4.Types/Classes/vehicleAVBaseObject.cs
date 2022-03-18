
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleAVBaseObject : vehicleBaseObject
	{
		public vehicleAVBaseObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
