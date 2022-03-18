
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemSmartObjects : worldIRuntimeSystem
	{
		public worldRuntimeSystemSmartObjects()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
