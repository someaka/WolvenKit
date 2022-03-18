
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NanoWireProjectileCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		public NanoWireProjectileCollisionEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
