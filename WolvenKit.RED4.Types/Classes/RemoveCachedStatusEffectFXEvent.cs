
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveCachedStatusEffectFXEvent : redEvent
	{
		public RemoveCachedStatusEffectFXEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
