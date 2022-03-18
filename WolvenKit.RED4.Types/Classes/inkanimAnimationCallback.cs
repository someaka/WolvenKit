
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimAnimationCallback : inkCallbackBase
	{
		public inkanimAnimationCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
