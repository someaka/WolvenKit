
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIScriptsTargetTrackingListenerWrapper : AIITargetTrackingListener
	{
		public AIScriptsTargetTrackingListenerWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
