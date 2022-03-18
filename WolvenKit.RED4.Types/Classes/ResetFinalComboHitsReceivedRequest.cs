
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetFinalComboHitsReceivedRequest : gameScriptableSystemRequest
	{
		public ResetFinalComboHitsReceivedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
