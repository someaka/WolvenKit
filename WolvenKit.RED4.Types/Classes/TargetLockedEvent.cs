
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetLockedEvent : redEvent
	{
		public TargetLockedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
