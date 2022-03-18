
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetNPCIncapacitatedDelayedRequest : gameScriptableSystemRequest
	{
		public ResetNPCIncapacitatedDelayedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
