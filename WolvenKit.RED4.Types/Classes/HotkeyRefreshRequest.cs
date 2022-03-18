
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HotkeyRefreshRequest : gamePlayerScriptableSystemRequest
	{
		public HotkeyRefreshRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
