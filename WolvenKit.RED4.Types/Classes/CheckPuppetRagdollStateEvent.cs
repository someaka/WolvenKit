
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckPuppetRagdollStateEvent : redEvent
	{
		public CheckPuppetRagdollStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
