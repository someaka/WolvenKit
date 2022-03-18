
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkPointerEvent : inkInputEvent
	{
		public inkPointerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
