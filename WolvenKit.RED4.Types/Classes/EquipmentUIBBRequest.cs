
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipmentUIBBRequest : gamePlayerScriptableSystemRequest
	{
		public EquipmentUIBBRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
