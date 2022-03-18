
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnlockPreventionInputRequest : gameScriptableSystemRequest
	{
		public UnlockPreventionInputRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
