
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SafeCrosshairStateEvents : BaseCrosshairStateEvents
	{
		public SafeCrosshairStateEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
