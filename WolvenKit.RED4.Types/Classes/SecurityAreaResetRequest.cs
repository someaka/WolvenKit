
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAreaResetRequest : gameScriptableSystemRequest
	{
		public SecurityAreaResetRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
