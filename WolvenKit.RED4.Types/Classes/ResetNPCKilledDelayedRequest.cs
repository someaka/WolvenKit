
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetNPCKilledDelayedRequest : gameScriptableSystemRequest
	{
		public ResetNPCKilledDelayedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
