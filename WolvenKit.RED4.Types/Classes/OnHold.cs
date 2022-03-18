
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnHold : inkPointerEvent
	{
		public OnHold()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
