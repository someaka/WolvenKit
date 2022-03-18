
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnPress : inkPointerEvent
	{
		public OnPress()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
