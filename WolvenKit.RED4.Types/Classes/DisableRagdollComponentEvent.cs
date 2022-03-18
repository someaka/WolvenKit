
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisableRagdollComponentEvent : redEvent
	{
		public DisableRagdollComponentEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
