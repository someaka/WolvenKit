
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCursorContextCallback : inkCallbackBase
	{
		public inkCursorContextCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
