
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClearBraindanceStateRequest : gameScriptableSystemRequest
	{
		public ClearBraindanceStateRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
