
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameweaponeventsRemoveActiveWeaponEvent : redEvent
	{
		public gameweaponeventsRemoveActiveWeaponEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
