
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnequipWardrobeSetRequest : gamePlayerScriptableSystemRequest
	{
		public UnequipWardrobeSetRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
