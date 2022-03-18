
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestReleaseControl : gameScriptableSystemRequest
	{
		public RequestReleaseControl()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
