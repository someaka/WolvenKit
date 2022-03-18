
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StartRagdollDamageEvent : redEvent
	{
		public StartRagdollDamageEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
