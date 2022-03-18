
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClearBraindancePauseRequest : gameScriptableSystemRequest
	{
		public ClearBraindancePauseRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
