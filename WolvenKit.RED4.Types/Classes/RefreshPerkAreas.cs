
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshPerkAreas : gamePlayerScriptableSystemRequest
	{
		public RefreshPerkAreas()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
