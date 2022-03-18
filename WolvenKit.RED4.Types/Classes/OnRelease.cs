
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnRelease : inkPointerEvent
	{
		public OnRelease()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
