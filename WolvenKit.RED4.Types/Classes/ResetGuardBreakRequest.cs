
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetGuardBreakRequest : gameScriptableSystemRequest
	{
		public ResetGuardBreakRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
