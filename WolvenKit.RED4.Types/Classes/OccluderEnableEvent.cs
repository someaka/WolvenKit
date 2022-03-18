
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OccluderEnableEvent : redEvent
	{
		public OccluderEnableEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
