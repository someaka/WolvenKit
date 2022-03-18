
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimationPauseEvent : gameTransformAnimationEvent
	{
		public gameTransformAnimationPauseEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
