
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMovingPlatformBeforeArrivedAt : redEvent
	{
		public gameMovingPlatformBeforeArrivedAt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
