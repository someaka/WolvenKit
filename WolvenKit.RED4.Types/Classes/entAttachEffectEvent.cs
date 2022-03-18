
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAttachEffectEvent : redEvent
	{
		public entAttachEffectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
