
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileScriptCollisionEvaluator : gameprojectileCollisionEvaluator
	{
		public gameprojectileScriptCollisionEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
