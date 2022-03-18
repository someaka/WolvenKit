
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveLinkEvent : redEvent
	{
		public RemoveLinkEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
