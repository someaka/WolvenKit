
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveObstacleDetectedEvent : redEvent
	{
		public moveObstacleDetectedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
