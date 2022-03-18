
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZoomTransition : DefaultTransition
	{
		public ZoomTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
