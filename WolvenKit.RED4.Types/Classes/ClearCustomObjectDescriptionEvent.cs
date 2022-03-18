
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClearCustomObjectDescriptionEvent : redEvent
	{
		public ClearCustomObjectDescriptionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
