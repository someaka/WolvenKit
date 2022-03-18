
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIScriptsTargetTrackingListener : AIITargetTrackingListener
	{
		public AIScriptsTargetTrackingListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
