
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRagdollDisableEvent : redEvent
	{
		public entRagdollDisableEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
