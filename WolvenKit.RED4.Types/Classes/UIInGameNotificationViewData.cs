
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIInGameNotificationViewData : gameuiGenericNotificationViewData
	{
		public UIInGameNotificationViewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
