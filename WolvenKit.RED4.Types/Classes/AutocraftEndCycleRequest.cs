
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AutocraftEndCycleRequest : gameScriptableSystemRequest
	{
		public AutocraftEndCycleRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
