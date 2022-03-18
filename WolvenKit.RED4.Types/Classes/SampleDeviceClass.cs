
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SampleDeviceClass : gameObject
	{
		public SampleDeviceClass()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
