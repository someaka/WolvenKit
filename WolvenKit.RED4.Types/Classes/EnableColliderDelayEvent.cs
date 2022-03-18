
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EnableColliderDelayEvent : DelayEvent
	{
		public EnableColliderDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
