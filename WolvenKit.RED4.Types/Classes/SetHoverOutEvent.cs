
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetHoverOutEvent : redEvent
	{
		public SetHoverOutEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
