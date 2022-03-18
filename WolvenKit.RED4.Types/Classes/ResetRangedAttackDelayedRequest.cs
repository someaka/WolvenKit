
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetRangedAttackDelayedRequest : gameScriptableSystemRequest
	{
		public ResetRangedAttackDelayedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
