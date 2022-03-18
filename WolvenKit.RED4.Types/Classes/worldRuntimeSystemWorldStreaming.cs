
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemWorldStreaming : worldIRuntimeSystem
	{
		public worldRuntimeSystemWorldStreaming()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
