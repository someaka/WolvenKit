
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AttributeUpdateEvent : redEvent
	{
		public AttributeUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
