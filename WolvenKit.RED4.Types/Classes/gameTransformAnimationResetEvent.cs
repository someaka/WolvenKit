
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimationResetEvent : gameTransformAnimationPlayEvent
	{
		public gameTransformAnimationResetEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
