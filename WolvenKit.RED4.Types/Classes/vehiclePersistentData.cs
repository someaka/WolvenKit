
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehiclePersistentData : gameComponent
	{
		public vehiclePersistentData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
