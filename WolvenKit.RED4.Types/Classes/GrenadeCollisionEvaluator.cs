
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		public GrenadeCollisionEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
