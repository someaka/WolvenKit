
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetMeleeAttackDelayedRequest : gameScriptableSystemRequest
	{
		public ResetMeleeAttackDelayedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
