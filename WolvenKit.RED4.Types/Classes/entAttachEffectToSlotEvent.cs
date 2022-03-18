
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAttachEffectToSlotEvent : entAttachEffectEvent
	{
		public entAttachEffectToSlotEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
