
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseCrosshairState : DefaultTransition
	{
		public BaseCrosshairState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
