using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSLastUsedWeapon : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lastUsedWeapon")] 
		public gameItemID LastUsedWeapon
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("lastUsedRanged")] 
		public gameItemID LastUsedRanged
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("lastUsedMelee")] 
		public gameItemID LastUsedMelee
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(3)] 
		[RED("lastUsedHeavy")] 
		public gameItemID LastUsedHeavy
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public gameSLastUsedWeapon()
		{
			LastUsedWeapon = new();
			LastUsedRanged = new();
			LastUsedMelee = new();
			LastUsedHeavy = new();
		}
	}
}
