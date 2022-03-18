
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdatePlayerDevelopment : gamePlayerScriptableSystemRequest
	{
		public UpdatePlayerDevelopment()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
