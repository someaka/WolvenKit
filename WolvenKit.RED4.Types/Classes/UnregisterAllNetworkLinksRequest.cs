
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterAllNetworkLinksRequest : gameScriptableSystemRequest
	{
		public UnregisterAllNetworkLinksRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
