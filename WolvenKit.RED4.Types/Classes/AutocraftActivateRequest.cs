
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AutocraftActivateRequest : gameScriptableSystemRequest
	{
		public AutocraftActivateRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
