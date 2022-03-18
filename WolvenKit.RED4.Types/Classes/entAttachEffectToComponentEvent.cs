
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAttachEffectToComponentEvent : entAttachEffectEvent
	{
		public entAttachEffectToComponentEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
