
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimatorComponentReplicatedState : netIComponentState
	{
		public gameTransformAnimatorComponentReplicatedState()
		{
			Enabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
