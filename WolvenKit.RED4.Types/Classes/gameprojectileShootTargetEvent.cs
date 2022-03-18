
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileShootTargetEvent : gameprojectileShootEvent
	{
		public gameprojectileShootTargetEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
