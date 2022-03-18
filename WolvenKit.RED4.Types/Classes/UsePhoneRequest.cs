
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UsePhoneRequest : gameScriptableSystemRequest
	{
		public UsePhoneRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
