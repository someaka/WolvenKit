
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetAttackDelayedRequest : gameScriptableSystemRequest
	{
		public ResetAttackDelayedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
