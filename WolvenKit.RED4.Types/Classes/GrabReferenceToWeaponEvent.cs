
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrabReferenceToWeaponEvent : redEvent
	{
		public GrabReferenceToWeaponEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
