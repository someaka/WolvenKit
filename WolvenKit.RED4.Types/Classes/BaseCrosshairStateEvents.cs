
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseCrosshairStateEvents : BaseCrosshairState
	{
		public BaseCrosshairStateEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
