
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshItemPlayerScalingEvent : redEvent
	{
		public RefreshItemPlayerScalingEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
