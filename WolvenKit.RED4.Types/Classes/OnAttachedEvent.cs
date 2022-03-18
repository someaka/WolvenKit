
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnAttachedEvent : redEvent
	{
		public OnAttachedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
