
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClearEquipmentRequest : gamePlayerScriptableSystemRequest
	{
		public ClearEquipmentRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
