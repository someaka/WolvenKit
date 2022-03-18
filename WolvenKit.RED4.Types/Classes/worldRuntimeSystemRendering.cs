
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemRendering : worldIRuntimeSystem
	{
		public worldRuntimeSystemRendering()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
