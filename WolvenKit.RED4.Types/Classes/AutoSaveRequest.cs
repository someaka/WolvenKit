
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AutoSaveRequest : gameScriptableSystemRequest
	{
		public AutoSaveRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
