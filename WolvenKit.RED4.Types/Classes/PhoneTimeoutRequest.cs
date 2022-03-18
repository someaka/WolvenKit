
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhoneTimeoutRequest : gameScriptableSystemRequest
	{
		public PhoneTimeoutRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
