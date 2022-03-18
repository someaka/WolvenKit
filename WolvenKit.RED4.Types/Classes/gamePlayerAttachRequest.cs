
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerAttachRequest : gamePlayerScriptableSystemRequest
	{
		public gamePlayerAttachRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
