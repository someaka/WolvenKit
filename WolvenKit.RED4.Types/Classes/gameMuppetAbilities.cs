using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetAbilities : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("canLook")] 
		public gameMuppetAbility CanLook
		{
			get => GetPropertyValue<gameMuppetAbility>();
			set => SetPropertyValue<gameMuppetAbility>(value);
		}

		[Ordinal(1)] 
		[RED("canMove")] 
		public gameMuppetAbility CanMove
		{
			get => GetPropertyValue<gameMuppetAbility>();
			set => SetPropertyValue<gameMuppetAbility>(value);
		}

		[Ordinal(2)] 
		[RED("canCrouch")] 
		public gameMuppetAbility CanCrouch
		{
			get => GetPropertyValue<gameMuppetAbility>();
			set => SetPropertyValue<gameMuppetAbility>(value);
		}

		[Ordinal(3)] 
		[RED("canSprint")] 
		public gameMuppetAbility CanSprint
		{
			get => GetPropertyValue<gameMuppetAbility>();
			set => SetPropertyValue<gameMuppetAbility>(value);
		}

		[Ordinal(4)] 
		[RED("canSwitchWeapon")] 
		public gameMuppetAbility CanSwitchWeapon
		{
			get => GetPropertyValue<gameMuppetAbility>();
			set => SetPropertyValue<gameMuppetAbility>(value);
		}

		[Ordinal(5)] 
		[RED("canHoldWeapon")] 
		public gameMuppetAbility CanHoldWeapon
		{
			get => GetPropertyValue<gameMuppetAbility>();
			set => SetPropertyValue<gameMuppetAbility>(value);
		}

		[Ordinal(6)] 
		[RED("canShoot")] 
		public gameMuppetAbility CanShoot
		{
			get => GetPropertyValue<gameMuppetAbility>();
			set => SetPropertyValue<gameMuppetAbility>(value);
		}

		[Ordinal(7)] 
		[RED("canAimDownSight")] 
		public gameMuppetAbility CanAimDownSight
		{
			get => GetPropertyValue<gameMuppetAbility>();
			set => SetPropertyValue<gameMuppetAbility>(value);
		}

		public gameMuppetAbilities()
		{
			CanLook = new();
			CanMove = new();
			CanCrouch = new();
			CanSprint = new();
			CanSwitchWeapon = new();
			CanHoldWeapon = new();
			CanShoot = new();
			CanAimDownSight = new();
		}
	}
}
