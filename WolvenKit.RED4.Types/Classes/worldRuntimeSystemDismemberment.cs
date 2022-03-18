
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemDismemberment : worldIRuntimeSystem
	{
		public worldRuntimeSystemDismemberment()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
