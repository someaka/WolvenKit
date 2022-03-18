
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnEnter : inkPointerEvent
	{
		public OnEnter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
