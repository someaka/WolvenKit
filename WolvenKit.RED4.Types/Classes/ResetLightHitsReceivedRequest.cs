
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetLightHitsReceivedRequest : gameScriptableSystemRequest
	{
		public ResetLightHitsReceivedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
