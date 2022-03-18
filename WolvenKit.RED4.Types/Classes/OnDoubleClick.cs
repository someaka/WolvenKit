
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnDoubleClick : inkPointerEvent
	{
		public OnDoubleClick()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
