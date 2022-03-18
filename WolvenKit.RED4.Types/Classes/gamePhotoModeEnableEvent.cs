
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePhotoModeEnableEvent : redEvent
	{
		public gamePhotoModeEnableEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
