
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathIsRagdollCondition : AIbehaviorconditionScript
	{
		public DeathIsRagdollCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
