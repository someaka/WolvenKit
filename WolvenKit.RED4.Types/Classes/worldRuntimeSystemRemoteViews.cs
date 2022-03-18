
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemRemoteViews : worldIRuntimeSystem
	{
		public worldRuntimeSystemRemoteViews()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
