
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionBlinkingStatusRequest : gameScriptableSystemRequest
	{
		public PreventionBlinkingStatusRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
