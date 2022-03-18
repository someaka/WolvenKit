
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkStateChangeCallback : inkCallbackBase
	{
		public inkStateChangeCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
