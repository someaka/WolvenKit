
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class C4Controller : ExplosiveDeviceController
	{
		public C4Controller()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
