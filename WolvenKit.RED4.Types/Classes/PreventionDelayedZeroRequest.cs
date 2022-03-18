
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionDelayedZeroRequest : gameScriptableSystemRequest
	{
		public PreventionDelayedZeroRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
