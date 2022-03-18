
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemNodeStreaming : worldIRuntimeSystem
	{
		public worldRuntimeSystemNodeStreaming()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
