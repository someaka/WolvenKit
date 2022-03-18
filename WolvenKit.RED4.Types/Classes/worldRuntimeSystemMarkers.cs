
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemMarkers : worldIRuntimeSystem
	{
		public worldRuntimeSystemMarkers()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
