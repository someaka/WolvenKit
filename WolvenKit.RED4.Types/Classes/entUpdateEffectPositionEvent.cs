
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entUpdateEffectPositionEvent : redEvent
	{
		public entUpdateEffectPositionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
