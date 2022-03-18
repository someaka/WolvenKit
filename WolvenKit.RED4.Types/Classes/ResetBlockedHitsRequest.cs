
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetBlockedHitsRequest : gameScriptableSystemRequest
	{
		public ResetBlockedHitsRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
