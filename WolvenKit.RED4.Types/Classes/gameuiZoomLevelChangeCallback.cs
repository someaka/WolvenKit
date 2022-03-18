
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiZoomLevelChangeCallback : inkCallbackBase
	{
		public gameuiZoomLevelChangeCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
