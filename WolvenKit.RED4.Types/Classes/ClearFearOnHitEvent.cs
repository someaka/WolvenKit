
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClearFearOnHitEvent : redEvent
	{
		public ClearFearOnHitEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
