
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemFoliage : worldIRuntimeSystem
	{
		public worldRuntimeSystemFoliage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
