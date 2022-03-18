
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkInputDeviceCallback : inkCallbackBase
	{
		public inkInputDeviceCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
