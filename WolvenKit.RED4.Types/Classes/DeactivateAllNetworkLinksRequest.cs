
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeactivateAllNetworkLinksRequest : gameScriptableSystemRequest
	{
		public DeactivateAllNetworkLinksRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
