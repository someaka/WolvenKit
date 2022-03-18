
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveAllFastTravelLocksRequest : gameScriptableSystemRequest
	{
		public RemoveAllFastTravelLocksRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
