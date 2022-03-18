
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BountyResetRequest : gameScriptableSystemRequest
	{
		public BountyResetRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
