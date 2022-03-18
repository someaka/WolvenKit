
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetStrongHitsReceivedRequest : gameScriptableSystemRequest
	{
		public ResetStrongHitsReceivedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
