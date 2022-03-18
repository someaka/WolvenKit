
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameForceResetAmmoEvent : redEvent
	{
		public gameForceResetAmmoEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
