
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NoReactionPerformedRequest : gameScriptableSystemRequest
	{
		public NoReactionPerformedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
