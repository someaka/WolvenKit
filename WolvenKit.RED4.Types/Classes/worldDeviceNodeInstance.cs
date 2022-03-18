
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDeviceNodeInstance : worldEntityNodeInstance
	{
		public worldDeviceNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
