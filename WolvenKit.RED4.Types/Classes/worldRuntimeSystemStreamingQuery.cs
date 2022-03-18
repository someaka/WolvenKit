
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemStreamingQuery : worldIRuntimeSystem
	{
		public worldRuntimeSystemStreamingQuery()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
