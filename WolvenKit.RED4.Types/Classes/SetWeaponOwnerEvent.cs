
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetWeaponOwnerEvent : redEvent
	{
		public SetWeaponOwnerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
