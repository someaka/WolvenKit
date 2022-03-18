
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StartOverheatEffectEvent : redEvent
	{
		public StartOverheatEffectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
