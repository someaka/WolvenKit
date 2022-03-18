
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		public WeaponCollisionEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
