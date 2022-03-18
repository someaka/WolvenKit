
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFearInPlaceEvent : AIAIEvent
	{
		public AIFearInPlaceEvent()
		{
			Name = "fearInPlace";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
