
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionTickRequest : gameScriptableSystemRequest
	{
		public PreventionTickRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
