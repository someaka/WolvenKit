
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetDeflectedHitsRequest : gameScriptableSystemRequest
	{
		public ResetDeflectedHitsRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
