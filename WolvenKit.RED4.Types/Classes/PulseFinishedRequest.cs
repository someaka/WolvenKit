
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PulseFinishedRequest : gameScriptableSystemRequest
	{
		public PulseFinishedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
