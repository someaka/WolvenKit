
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimEntityToEntityAttachmentEvent : redEvent
	{
		public entAnimEntityToEntityAttachmentEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
