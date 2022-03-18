
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemTraffic : worldIRuntimeSystem
	{
		public worldRuntimeSystemTraffic()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
