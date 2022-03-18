
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReenableColliderEvent : redEvent
	{
		public ReenableColliderEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
