
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetNPCFinishedDelayedRequest : gameScriptableSystemRequest
	{
		public ResetNPCFinishedDelayedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
