
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClearAllWeaponSlotsRequest : gamePlayerScriptableSystemRequest
	{
		public ClearAllWeaponSlotsRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
