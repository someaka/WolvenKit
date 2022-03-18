
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiHoldIndicatorProgressCallback : inkCallbackBase
	{
		public gameuiHoldIndicatorProgressCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
