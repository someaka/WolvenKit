
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetBlockAttackHitsReceivedRequest : gameScriptableSystemRequest
	{
		public ResetBlockAttackHitsReceivedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
